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
namespace Essay
{
    public partial class frmMain : KryptonForm
    {
        private frmLogin frmLogin;
        private static bool isExpandedNav = true;

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

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnTittle = new DraggableKryptonPanel(pnTittle, this);



        }

        private void pnNavbar_Paint(object sender, PaintEventArgs e)
        {

        }


        //Title custom
        private void ptbMini_MouseHover(object sender, EventArgs e)
        {
            panelMini.StateCommon.Color1 = Color.FromArgb(100, 250, 250, 250);
        }

        private void ptbClose_MouseHover(object sender, EventArgs e)
        {
            panelClose.StateCommon.Color1 = Color.FromArgb(100, 250, 250, 250);

        }



        private void ptbMini_MouseLeave(object sender, EventArgs e)
        {
            panelMini.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            panelMini.StateCommon.Color2 = Color.FromArgb(221, 221, 218);

        }

        private void ptbClose_MouseLeave(object sender, EventArgs e)
        {

            panelClose.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            panelClose.StateCommon.Color2 = Color.FromArgb(221, 221, 218);
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

        private void timerNavBar_Tick(object sender, EventArgs e)
        {
            if (isExpandedNav)
            {
                pnNavbar.Width -= 60;
                if (pnMenuNav.Width <= pnNavbar.MinimumSize.Width)
                {
                    isExpandedNav = false;
                    timerNavBar.Stop();
                }

            }
            else
            {
                pnNavbar.Width += 60;
                if (pnMenuNav.Width >= pnNavbar.MaximumSize.Width)
                {
                    isExpandedNav = true;
                    timerNavBar.Stop();
                }
            }
        }

        private void pnMenuNav_Click(object sender, EventArgs e)
        {

            timerNavBar.Start();
        }
    }
}
