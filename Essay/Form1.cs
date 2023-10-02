namespace Essay
{
    public partial class Form1 : Form
    {
        private bool isResizing = false;
        private Point mouseDownLocation;
        private const int resizeMargin = 10;

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Form1_MouseUp);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                if (e.Location.X <= resizeMargin && e.Location.Y <= resizeMargin)
                {
                    isResizing = true;
                    mouseDownLocation = e.Location;
                }
                else if (e.Location.X <= resizeMargin && e.Location.Y >= this.ClientSize.Height - resizeMargin)
                {
                    isResizing = true;
                    mouseDownLocation = new Point(e.Location.X, this.Height);
                }
                else if (e.Location.X >= this.ClientSize.Width - resizeMargin && e.Location.Y <= resizeMargin)
                {
                    isResizing = true;
                    mouseDownLocation = new Point(this.Width, e.Location.Y);
                }
                else if (e.Location.X >= this.ClientSize.Width - resizeMargin && e.Location.Y >= this.ClientSize.Height - resizeMargin)
                {
                    isResizing = true;
                    mouseDownLocation = new Point(this.Width, this.Height);
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                int dx = e.X - mouseDownLocation.X;
                int dy = e.Y - mouseDownLocation.Y;


                int newWidth = this.Width + dx;
                int newHeight = this.Height + dy;
                if (newWidth > 0 && newHeight > 0)
                {
                    this.Size = new Size(newWidth, newHeight);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }


    }

}