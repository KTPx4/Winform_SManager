using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay.Pages.Items
{
    public partial class FUser : UserControl
    {
        Action<FUser> DeleteUser;
        public FUser()
        {
            InitializeComponent();
        }
        public FUser(Action<FUser> deleteU)
        {
            InitializeComponent();
            DeleteUser = deleteU;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteUser(this);
        }
        private Color GenerateRandomColor()
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            return randomColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            panel1.BackColor = GenerateRandomColor();
        }
    }
}
