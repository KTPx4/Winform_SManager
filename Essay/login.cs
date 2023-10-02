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

namespace Essay
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        private String titlePanel = "#306ed8";

        private bool _dragging = false;
        private Point _startPoint;





        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            Test t = new Test();
            t.user = "px4";




        }

        private void HoverPanel(Panel p, Color color)
        {
            p.BackColor = color;
        }

        private void ptbMini_MouseHover(object sender, EventArgs e)
        {
            panelMini.BackColor = System.Drawing.ColorTranslator.FromHtml(titlePanel);
        }

        private void ptbClose_MouseHover(object sender, EventArgs e)
        {
            panelClose.BackColor = System.Drawing.ColorTranslator.FromHtml(titlePanel);

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
    }
}