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
//using Components;
using Essay.Pages;
using Essay.Pages.Dialog;
using Components;

namespace Essay
{
    public partial class frmMain : KryptonForm
    {
        public String NameUser { get; set; }
        public String TypeUser { get; set; }
        public String linkAvt {  get; set; }



        private bool once = false;
        private frmLogin frmLogin = null;
        public Action<int> ULocationP;
        private static bool isTabUsers = false;

        private String User;

        public frmMain()
        {

            /*
            frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }*/

            InitializeComponent();
           
            

        }
        private void setupProfile()
        {
            lbName.Text = NameUser;
            lbTypeUser.Text = TypeUser;
            btnProfile.StateCommon.Back.Image = Image.FromFile($"{Variables._pathAvt}/{linkAvt}");
        //    btnProfile.StateCommon.Back.Image = Image.FromFile($"{Variables._pathAvt}/husky2.png");
        }
        private void Style()
        {
            bdLine2.Hide();

            //Navbar
            // panel
            pnNavbar.StateCommon.Color1 = Variables._BackGround;
            pnMenuNav.BackColor = Variables._BackGround;
            pn1.BackColor = Variables._BackGround;
            pn2.BackColor = Variables._BackGround;

            pnListsNavs.BackColor = Variables._BackNav;
            pnAllNavbar.BackColor = Variables._BackNav;
            pnAvt.BackColor = Variables._BackNav;

            // label
            lbName.BackColor = Variables._BackNav;
            lbTypeUser.BackColor = Variables._BackNav;



            //title
            //panel
            pnTitle.BackColor = Variables._BackGround;
            pnRightTitle.BackColor = Variables._BackGround;
            pnMini.BackColor = Variables._BackGround;
            pnClose.BackColor = Variables._BackGround;

            //label
            lbTitleForm.BackColor = Variables._BackGround;



            //content
            pnContent.BackColor = Variables._BackGround;



        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnTitle = new DraggablePanel(pnTitle, this);

            Style(); 
            setupProfile();


        }

        private void pnNavbar_Paint(object sender, PaintEventArgs e)
        {

        }


        //Title custom
        private void ptbMini_MouseHover(object sender, EventArgs e)
        {
            pnMini.BackColor = Variables._BtnTitle;
        }

        private void ptbClose_MouseHover(object sender, EventArgs e)
        {
            pnClose.BackColor = Variables._BtnTitle;

        }

        private void ptbMini_MouseLeave(object sender, EventArgs e)
        {

            pnMini.BackColor = Color.Transparent;

        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {


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
            pnAvt.BackColor = Variables._HoverENav;
            lbName.BackColor = Variables._HoverENav;
            lbTypeUser.BackColor = Variables._HoverENav;
        }
        private void LeaveAvt(object sender, EventArgs e)
        {
            //pnAvt.BackColor = Color.FromArgb(255, 76, 86, 97);

            pnAvt.BackColor = Variables._BackNav;
            lbName.BackColor = Variables._BackNav;
            lbTypeUser.BackColor = Variables._BackNav;
        }

        private void pnMenuNav_MouseHover(object sender, EventArgs e)
        {
            pnMenuNav.BackColor = Variables._HoverENav;
        }

        private void pnMenuNav_MouseLeave(object sender, EventArgs e)
        {
            pnMenuNav.BackColor = Variables._BackGround;
        }

        private void showText(bool b)
        {
            if (b)
            {
                btnStudents.Text = "Students";
                btnHome.Text = "Home";
                btnReport.Text = "Report";
                btnUsers.Text = "Users";

            }
            else
            {
                btnStudents.Text = "";
                btnHome.Text = "";
                btnReport.Text = "";
                btnUsers.Text = "";

            }
        }
        // click navbar
        private void timerNavBar_Tick(object sender, EventArgs e)
        {

            if (Variables._isExpandedNav)
            {


                Variables._Width_SetCent = 45;
                if (isTabUsers && !once) // move to center/default when the navbar change 
                {
                    once = !once; // true
                    // ULocationP(100);

                }

                pnNavbar.Width -= 60;

                if (pnNavbar.Width <= pnNavbar.MinimumSize.Width)
                {

                    Variables._isExpandedNav = false;

                    pnMenuNav.BackgroundImage = Properties.Resources.icons8_double_right_16;
                    bdLine1.Hide();
                    bdLine2.Show();
                    pnAllNavbar.BorderStyle = BorderStyle.None;
                    showText(false);


                    this.ResumeLayout();
                    once = !once; // false
                    timerNavBar.Stop();

                }

            }
            else
            {


                Variables._Width_SetCent = 0;
                if (isTabUsers && !once) // move to center/default when the navbar change
                {
                    once = !once; // true
                                  // ULocationP(-100);

                }


                pnNavbar.Width += 60;

                if (pnNavbar.Width >= pnNavbar.MaximumSize.Width)
                {

                    Variables._isExpandedNav = true;
                    pnMenuNav.BackgroundImage = Properties.Resources.icons8_double_left_16;
                    bdLine1.Show();
                    bdLine2.Hide();
                    pnAllNavbar.BorderStyle = BorderStyle.FixedSingle;
                    showText(true);

                    this.ResumeLayout();
                    once = !once; // false
                    timerNavBar.Stop();
                }
            }
        }

        private void pnMenuNav_Click(object sender, EventArgs e)
        {

            this.SuspendLayout();
            timerNavBar.Start();

        }

        //hover and leave button in nav
        private void HoverBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Variables._HoverBtn;
        }
        private void LeaveHoverBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }



        //Event button
        private void btnUsers_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
            isTabUsers = true;
            frmMUser user = new frmMUser();
            ULocationP = user.ULocationP;
            // user.Anchor = AnchorStyles.Right;
            pnContent.Controls.Add(user);
            user.Dock = DockStyle.Fill;
            this.lbTitleForm.Text = "Manager User";


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();
        }


        // open profile
        private void OpenProfile()
        {
            dialogProfile pf = new dialogProfile("Pxk3", 1);
            pf.Show();

        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }
    }
}
