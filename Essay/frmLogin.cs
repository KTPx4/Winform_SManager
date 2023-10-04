using DevExpress.Utils;
using DevExpress.XtraEditors;
using Essay.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Controls;
using DevExpress.XtraReports.UI;


namespace Essay
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private String titlePanel = "#306ed8";

        private bool _dragging = false;
        private Point _startPoint;





        public frmLogin()
        {
            InitializeComponent();
            Style(); ;
        }

        private void login_Load(object sender, EventArgs e)
        {




        }

        private void Style()
        {

            // Tạo một instance của RJPanel
            panelLogin.BackColor = Color.FromArgb(100, 183, 195, 199);


            // this.Controls.Add(PanelLogin);

        }

        //Title 
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
            this.Close();
        }

        private void ptbMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Title moving
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }

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
    }
}