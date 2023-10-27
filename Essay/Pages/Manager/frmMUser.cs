using Essay.Components;
using Essay.Pages.Dialog;
using Essay.Pages.Items;

using System;
using System.Data;
using System.Data.Linq;
using System.Linq;

namespace Essay.Pages
{


    public partial class frmMUser : UserControl
    {
        private CustomList<FUser> ListItems = new CustomList<FUser>();



        public Action<int> ULocationP;
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
            // setLocation();
            cbbType.SelectedIndex = 0;

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
        private void addManager_Click(object sender, EventArgs e)
        {

            //dialogProfile dialogProfile = new dialogProfile(1, 0)
            //{
            //    id = "1243",
            //    name = "px4",
            //    user = "px4k3",
            //    password = "kkkk",
            //    phone = "1111111",
            //    Status = 0,
            //    birthDay = new DateTime(2023, 10,20)

            //};
            //dialogProfile.Show();


            //FUser us = new FUser(deleteUser, true, "000", "fsf smith", "00001111", true, "");

            ////    us.Controls["pnID"].Location = new Point(Variables._X_Item_User, us.Controls["pnID"].Location.Y);

            //ListItems.Add(us);
            //pnListItems.Controls.Add(us);

            //us.Dock = DockStyle.Top;

        }
        private void addStaff_Click(object sender, EventArgs e)
        {


            FUser us = new FUser(deleteUser, false, "11", "Joinh smith", "00001111", false, "husky2.png");
            //   us.Controls["pnID"].Location = new Point(Variables._X_Item_User, us.Controls["pnID"].Location.Y);

            ListItems.Add(us);
            pnListItems.Controls.Add(us);

            us.Dock = DockStyle.Top;
        }

        private void setLocation()
        {
            pnSetCenter.Width = Variables._Width_SetCent;
        }

        private void upLocationP(int x)
        {

            try
            {

                this.Width = this.Width + x;

                //pnSetCenter.Width = Variables._Width_SetCent;

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





        private void frmMUser_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;
            kryptonBorderEdge1.Hide();

            //DataContextDataContext testdb = new DataContextDataContext();

            //Admin ad = new Admin()
            //{
            //    User = "px4",
            //    Password = "12345",
            //    Name = "px4k3",
            //    LinkAVT = "/img"
            //};
            //testdb.Admins.InsertOnSubmit(ad);
            //testdb.SubmitChanges();

            //dgvT.DataSource = testdb.Admins.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.Directory.CreateDirectory(Variables._pathAvt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
