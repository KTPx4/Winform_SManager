using Essay.Components;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Essay.Components;
using Component;
using Essay.Pages;

namespace Essay
{
    public partial class frmMain : KryptonForm
    {
        private frmLogin frmLogin = null;
        private static bool isExpandedNav = true;
        public Action<int, int> ULocationP;
        private static bool isTabUsers = false;
        public frmMain()
        {

            /*
            frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }*/

            InitializeComponent();
            Style();

        }

        private void Style()
        {
            bdLine2.Hide();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnTitle = new DraggablePanel(pnTitle, this);
            


        }

        private void pnNavbar_Paint(object sender, PaintEventArgs e)
        {

        }
      

        //Title custom
        private void ptbMini_MouseHover(object sender, EventArgs e)
        {
            pnMini.BackColor = Color.FromArgb(100, 250, 250, 250);
        }

        private void ptbClose_MouseHover(object sender, EventArgs e)
        {
            pnClose.BackColor = Color.FromArgb(100, 250, 250, 250);

        }



        private void ptbMini_MouseLeave(object sender, EventArgs e)
        {
            // panelMini.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            //panelMini.StateCommon.Color2 = Color.FromArgb(221, 221, 218);
            pnMini.BackColor = Color.Transparent;

        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {

            // panelClose.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            //panelClose.StateCommon.Color2 = Color.FromArgb(221, 221, 218);
            pnClose.BackColor = Color.Transparent;

        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Close?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void ptbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HoverAvt(object sender, EventArgs e)
        {
            pnAvt.BackColor = Color.FromArgb(255, 76, 86, 97);
        }
        private void LeaveAvt(object sender, EventArgs e)
        {
            //pnAvt.BackColor = Color.FromArgb(255, 76, 86, 97);

            pnAvt.BackColor = Color.Transparent;
        }

        private void pnMenuNav_MouseHover(object sender, EventArgs e)
        {
            pnMenuNav.BackColor = Color.FromArgb(255, 76, 86, 97);
        }

        private void pnMenuNav_MouseLeave(object sender, EventArgs e)
        {
            pnMenuNav.BackColor = Color.Transparent;
        }


        // click navbar
        private void timerNavBar_Tick(object sender, EventArgs e)
        {
            
            if (isExpandedNav)
            {
                if(isTabUsers)
                {
                    ULocationP(20, 0);
                }
                pnNavbar.Width -= 60;
                if (pnNavbar.Width <= pnNavbar.MinimumSize.Width)
                {
                    isExpandedNav = false;

                    pnMenuNav.BackgroundImage = Properties.Resources.icons8_double_right_16;
                    bdLine1.Hide();
                    bdLine2.Show();
                    pnAllNavbar.BorderStyle = BorderStyle.None;
                    btnStudents.Text = "";

                    timerNavBar.Stop();
                }

            }
            else
            {
                if (isTabUsers)
                {
                    ULocationP(-20, 0);
                }
                pnNavbar.Width += 60;
                if (pnNavbar.Width >= pnNavbar.MaximumSize.Width)
                {
                    isExpandedNav = true;
                    pnMenuNav.BackgroundImage = Properties.Resources.icons8_double_left_16;
                    bdLine1.Show();
                    bdLine2.Hide();
                    pnAllNavbar.BorderStyle = BorderStyle.FixedSingle;
                    btnStudents.Text = "Students";

                    timerNavBar.Stop();
                }
            }
        }

        private void pnMenuNav_Click(object sender, EventArgs e)
        {

            timerNavBar.Start();

        }

        private void pnGAvt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bdLine1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMenuNav_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            isTabUsers = true;
            frmMUser user = new frmMUser();
            ULocationP = user.ULocationP;
            user.Dock = DockStyle.Fill;
            pnContent.Controls.Add(user);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
        }
    }
}
