using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Components;
using Essay.Controllers;
using Essay.Model;

namespace Essay
{
    public partial class frmLogin : Form
    {


        private bool _dragging = false;
        private Point _startPoint;
        private String Password = "";


        private Action<String, String, int> UpdateMain;

        public frmLogin(Action<String, String, int> update)
        {
            InitializeComponent();
            this.UpdateMain = update;
        }

        //Form load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Style();

        }

        private void Style()
        {

            panelLogin.BackColor = Color.FromArgb(100, 183, 195, 199);

            //Moving form
            panelTitle = new DraggablePanel(panelTitle, this);


        }

        //Title custom
        private void ptbMini_MouseHover(object sender, EventArgs e)
        {
            panelMini.BackColor = Color.FromArgb(100, 250, 250, 250);
        }

        private void ptbClose_MouseHover(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.FromArgb(100, 250, 250, 250);

        }

        private void ptbMini_MouseLeave(object sender, EventArgs e)
        {
            panelMini.BackColor = Color.Transparent;
        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {
            panelClose.BackColor = Color.Transparent;
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Close?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void ptbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }





        // buton login
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackgroundColor = Color.Fuchsia;
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundColor = Color.Transparent;
            btnLogin.ForeColor = Color.Fuchsia;
        }


        // btn Clear text
        private void btnClear_Hover(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;

            ptb.Size = new Size(17, 18);


        }
        private void btnClear_Leave(object sender, EventArgs e)
        {
            PictureBox ptb = (PictureBox)sender;

            ptb.Size = new Size(15, 16);

        }

        private void ptbClear_1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void ptbClear_2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }







        //show - hide pass



        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Password);
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = ckShow.Checked ? '\0' : '*';
        }


        // Action for Login

        private void Login()
        {
            if (txtPass.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Username or Password is invalid", "Login Failed");
            }
            else
            {
                String user = txtUser.Text;
                String pass = txtPass.Text;

                int TypeUs = AdminController.ValidLogin(user, pass);

                String name = "", path = "";
                if (TypeUs == -1)
                {
                    MessageBox.Show("User name or Password not Correct!", "Login Failed", MessageBoxButtons.OK);
                    return;
                }
                else if (TypeUs == -10 || TypeUs == -11) // Have Account, but have been blocked
                {
                    MessageBox.Show("Your Account is BLOCKED\nPlease call Admin to unlocked!", "Login Failed", MessageBoxButtons.OK);
                    return;
                }

                DateTime timeLogin = DateTime.Now;

                if (TypeUs == 0) // manager
                {
                    Manager a = ManagerController.GetFromUser(user);
                    name = a.Name;
                    path = a.LinkAVT;
                    ManagerController.WriteHistory(a, timeLogin); // write history login
                }
                else if (TypeUs == 1) // employee
                {
                    Employee a = EmployeeController.GetFromUser(user);

                    name = a.Name;
                    path = a.LinkAVT;

                    EmployeeController.WriteHistory(a, timeLogin);// write history login
                }
                else if (TypeUs == 2) // Admin
                {
                    Admin a = AdminController.GetFromUser(user);
                    name = a.Name;
                    path = a.LinkAVT;
                }

                AdminController.SetisOnline(user, true); // set online

                MessageBox.Show($"Welcom '{user}'!", "Login Success", MessageBoxButtons.OK);
                //  frmMain frmMain = new frmMain(name, TypeUs, path);
                // frmMain.Show();
                //  this.Hide();
                UpdateMain(user, path, TypeUs);
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }



    }
}
