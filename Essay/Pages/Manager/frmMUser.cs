using DevExpress.Map.Native;
using Essay.Components;
using Essay.Controllers;
using Essay.Model;
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
        public Action ReloadForm;

        //private String id = "ID";
        //private int num = 1;
        //int x_Items = 20;
        private int status = 0;
        private int typeUser = -1;

        public frmMUser()
        {
            InitializeComponent();

            ULocationP = upLocationP;
            deleteUser = DeleteUser;
            ReloadForm = Reload;

            frmMain.Instance.ReloadRequested += ReloadForm;
        }

        private void Reload()
        {
            LoadForm();
        }


        private void LoadDB() // for load list user from db
        {
            try
            {
                pnListItems.Controls.Clear();
                FUser title = new FUser();
                title.Dock = DockStyle.Top;
                pnListItems.Controls.Add(title);
                List<Manager> listManager = ManagerController.GetListActive();
                List<Employee> listEmployee = EmployeeController.GetListActive();



                switch (status) // status of user
                {
                    case -1: // deleted
                        listEmployee = EmployeeController.GetListDeleted();
                        listManager = ManagerController.GetListDeleted();
                        break;

                    case 1: // blocked
                        listEmployee = EmployeeController.GetListBlocked();
                        listManager = ManagerController.GetListBlocked();
                        break;

                    default: // 0 or other - Active

                        break;
                }

                switch (typeUser) // type of user : manager - employee
                {
                    case 0: // only manager
                        listEmployee = new List<Employee>();
                        break;

                    case 1: // only employee
                        listManager = new List<Manager>();
                        break;

                    default: // all of 2
                        break;
                }

                int countM = listManager.Count;
                int countE = listEmployee.Count;
                lbSumManager.Text = $"{countM} People";
                lbSumEmployee.Text = $"{countE} People";
                lbSumAll.Text = $"{countM + countE} People";

                foreach (var m in listManager)
                {
                    FUser f = new FUser(deleteUser)
                    {
                        _isManager = true,
                        _UserName = m.User,
                        _Name = m.Name,
                        _Phone = m.Phone,
                        _isOnline = (bool)m.isOnline,
                        _LinkAvt = m.LinkAVT
                    };

                    ListItems.Add(f); // add to list item
                    pnListItems.Controls.Add(f); // add to content panel
                    f.Dock = DockStyle.Top;

                }

                foreach (var em in listEmployee)
                {
                    FUser f = new FUser(deleteUser)
                    {
                        _isManager = false,
                        _UserName = em.User,
                        _Name = em.Name,
                        _Phone = em.Phone,
                        _isOnline = (bool)em.isOnline,
                        _LinkAvt = em.LinkAVT
                    };

                    ListItems.Add(f); // add to list item
                    pnListItems.Controls.Add(f); // add to content panel
                    f.Dock = DockStyle.Top;

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error :" + e.Message);
            }

        }

        private void LoadForm()
        {
            cbbType.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;
            kryptonBorderEdge1.Hide();
            LoadDB();
        }

        private void frmMUser_Load(object sender, EventArgs e)
        {
            LoadForm();


            //load list

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




        private void DeleteUser(FUser u)
        {
            if (u != null)
            {
                // ListItems.Remove(u);
                //pnListItems.Controls.Remove(u);
                LoadDB();
            }

        }

        // load from list<T>
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
            //    birthDay = new DateTime(2023, 10, 20),
            //    linkAvt = "husky2.png"

            //};
            //dialogProfile.Show();

            dialogProfile dialogProfile = new dialogProfile(0, 0);  // open = 0 -> add , user =0 -> manager 
            dialogProfile.Show();
            //FUser us = new FUser(deleteUser, true, "000", "fsf smith", "00001111", true, "");

            ////    us.Controls["pnID"].Location = new Point(Variables._X_Item_User, us.Controls["pnID"].Location.Y);

            //ListItems.Add(us);
            //pnListItems.Controls.Add(us);

            //us.Dock = DockStyle.Top;

        }
        private void addStaff_Click(object sender, EventArgs e)
        {


            //   FUser us = new FUser(deleteUser, false, "11", "Joinh smith", "00001111", false, "husky2.png");
            //   us.Controls["pnID"].Location = new Point(Variables._X_Item_User, us.Controls["pnID"].Location.Y);

            //ListItems.Add(us);
            // pnListItems.Controls.Add(us);

            //us.Dock = DockStyle.Top;

            dialogProfile dialogProfile = new dialogProfile(0, 1); // add - employee
            dialogProfile.Show();
            // AdminController adminController = new AdminController();
            // adminController.isExistsUser("px4d");

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

        private void Reload_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbStatus.SelectedIndex == 1)
            {
                status = 1;

            }
            else if (cbbStatus.SelectedIndex == 2)
            {
                status = -1;

            }
            else if (cbbStatus.SelectedIndex == 0)
            {
                status = 0;

            }

            LoadDB();

        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbType.SelectedIndex)
            {
                case 0:
                    typeUser = -1;
                    break;

                case 1:
                    typeUser = 0;
                    break;

                case 2:
                    typeUser = 1;
                    break;
            }
            LoadDB();
        }
    }
}
