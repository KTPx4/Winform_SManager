using Essay.Components;
using Essay.Pages.Items;
using System;
using System.Linq;

namespace Essay.Pages
{


    public partial class frmMUser : UserControl
    {
        private CustomList<FUser> ListItems = new CustomList<FUser>();



        public Action ULocationP;
        public Action<FUser> deleteUser;

        private String id = "ID";
        private int num = 1;
        int x_Items = 20;

        public frmMUser()
        {
            InitializeComponent();
            ULocationP = upLocationP;
            deleteUser = DeleteUser;
            Style();
        }
        private void Style()
        {
            upLocationP();
            //pnTitleItems.Location = new Point(x_Items + 50, pnTitleItems.Location.Y);
            // pnTitleItems.Location = new Point(VariableMain._X_Label_User, pnTitleItems.Location.Y);
        }
        private void DeleteUser(FUser u)
        {
            if (u != null)
            {
                ListItems.Remove(u);
                //  loadListItems();
                pnListItems.Controls.Remove(u);
            }

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadListItems()
        {
            try
            {
                pnListItems.Controls.Clear();

                if (ListItems != null)
                {

                    foreach (FUser item in ListItems)
                    {
                        pnListItems.Controls.Add(item);
                        item.Dock = DockStyle.Top;
                    }
                }


            }
            catch (Exception ex)
            {
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            String ids = id + num.ToString();
            num++;
            FUser us = new FUser(deleteUser, ids);
            us.Controls["pnID"].Location = new Point(Variables._X_Item_User, us.Controls["pnID"].Location.Y);

            ListItems.Add(us);
            pnListItems.Controls.Add(us);

            us.Dock = DockStyle.Top;

        }

        private void upLocationP()
        {

            try
            {
                pnSetCenter.Width = Variables._Width_SetCent;
                //    pnTitleItems.Location = new Point(VariableMain._X_Label_User, pnTitleItems.Location.Y);
                /*foreach (FUser item in ListItems)
                {
                    if (item.Controls["pnID"] != null)
                    {
                        item.Controls["pnID"].Location = new Point(x, item.Controls["pnID"].Location.Y + y);

                      
                    }

                }*/
            }
            catch (Exception ex)
            {

            }



        }

        private void kryptonPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(pnTitleItems.Location.X.ToString() + ";" + pnTitleItems.Location.Y.ToString());
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnListItems_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
