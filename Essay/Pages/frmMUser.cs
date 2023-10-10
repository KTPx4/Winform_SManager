using Essay.Pages.Items;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay.Pages
{
    public partial class frmMUser : UserControl
    {
        private List<FUser> ListItems = new List<FUser>();
        private List<String> IDU = new List<String>();

        public Action<int, int> ULocationP;
        public Action<FUser> deleteUser;
        private String id = "ID";
        private int num = 1;

        public frmMUser()
        {
            InitializeComponent();
            ULocationP = upLocationP;
            deleteUser = DeleteUser;
        }
        private void DeleteUser(FUser u)
        {
            if (u != null)
            {
                ListItems.Remove(u);
                pnListItems.Controls.Remove(u);

            }

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ids = id + num.ToString();
            num++;
            FUser us = new FUser(deleteUser);
            us.Controls["panel1"].Name = ids;
            IDU.Add(ids);
            ListItems.Add(us);
            us.Dock = DockStyle.Top;
            pnListItems.Controls.Add(us);
        }

        private void upLocationP(int x, int y)
        {
            string id = "id1";
            int i = 0;
            foreach (FUser item in ListItems)
            {
                if (item.Controls[IDU[i]] != null)
                {
                    item.Controls[IDU[i]].Location = new Point(item.Controls[IDU[i]].Location.X + x, item.Controls[IDU[i]].Location.Y + y);
                    i++;
                }

            }
        }


    }
}
