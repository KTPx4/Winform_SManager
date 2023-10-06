using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Component
{
    public class DraggableKryptonPanel : KryptonPanel
    {
        private Panel panel;
        private Form form;
        private bool _dragging;
        private Point _startPoint;

        public DraggableKryptonPanel(KryptonPanel panel, Form form)
        {
            this.panel = panel;
            this.form = form;

            // Đăng ký các sự kiện chuột cho Panel
            panel.MouseDown += Panel_MouseDown;
            panel.MouseUp += Panel_MouseUp;
            panel.MouseMove += Panel_MouseMove;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = panel.PointToScreen(e.Location);
                form.Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }
    }

    public class DraggablePanel : Panel
    {
        private Panel panel;
        private Form form;
        private bool _dragging;
        private Point _startPoint;

        public DraggablePanel(Panel panel, Form form)
        {
            this.panel = panel;
            this.form = form;

            // Đăng ký các sự kiện chuột cho Panel
            panel.MouseDown += Panel_MouseDown;
            panel.MouseUp += Panel_MouseUp;
            panel.MouseMove += Panel_MouseMove;

        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = panel.PointToScreen(e.Location);
                form.Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }
    }


}



