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
using System.Windows.Documents;

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
        private int status = 0; // cho combo box trạng thái của user: deleted, blocked, active
        private int typeUser = -1; // phân chia loại để sắp xếp và tìm kiếm: 0: manager - 1: employee 
        private int typeU; // Dùng để chia quyền khi đăng nhập vào form
                           // 0: Manager
                           // 1:Employee
                           // 2:Admin
        public frmMUser()
        {
            InitializeComponent();

            ULocationP = upLocationP;
            deleteUser = DeleteUser;
            ReloadForm = Reload;

            frmMain.Instance.ReloadRequested += ReloadForm;
        }
        public frmMUser(int typeU)
        {
            InitializeComponent();

            ULocationP = upLocationP;
            deleteUser = DeleteUser;
            ReloadForm = Reload;

            frmMain.Instance.ReloadRequested += ReloadForm;
            this.typeU = typeU;
        }

        private void Reload()
        {
            LoadForm();
        }


        private void loadAdmin()
        {
            ListItems = new CustomList<FUser>();
            pnListItems.Controls.Clear();
            FUser title = new FUser();
            title.Dock = DockStyle.Top;
            pnListItems.Controls.Add(title);



            List<Manager> listManager = new ManagerController().GetListActive();
            List<Employee> listEmployee = new EmployeeController().GetListActive();



            switch (status) // status of user
            {
                case -1: // deleted
                    listEmployee = new EmployeeController().GetListDeleted();
                    listManager = new ManagerController().GetListDeleted();
                    break;

                case 1: // blocked
                    listEmployee = new EmployeeController().GetListBlocked();
                    listManager = new ManagerController().GetListBlocked();
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
                    _LinkAvt = m.LinkAVT,
                    _Status = (int)m.Status
                };
                // MessageBox.Show($"{m.User},{m.isOnline}");

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
                    _LinkAvt = em.LinkAVT,
                    _Status = (int)em.Status
                };
                //  MessageBox.Show($"{em.User},{em.isOnline}");
                ListItems.Add(f); // add to list item
                pnListItems.Controls.Add(f); // add to content panel
                f.Dock = DockStyle.Top;

            }
        }

        private void loadManager()
        {
            pnListItems.Controls.Clear();
            FUser title = new FUser();
            title.Dock = DockStyle.Top;
            pnListItems.Controls.Add(title);
            // List<Manager> listManager = ManagerController.GetListActive();
            List<Employee> listEmployee = new EmployeeController().GetListActive();



            switch (status) // status of user
            {
                case -1: // deleted
                    listEmployee = new EmployeeController().GetListDeleted();
                    //listManager = ManagerController.GetListDeleted();
                    break;

                case 1: // blocked
                    listEmployee = new EmployeeController().GetListBlocked();
                    // listManager = ManagerController.GetListBlocked();
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
                        // listManager = new List<Manager>();
                    break;

                default: // all of 2
                    break;
            }

            // int countM = listManager.Count;
            int countE = listEmployee.Count;
            lbSumManager.Text = $"Unknow";
            lbSumEmployee.Text = $"{countE} People";
            lbSumAll.Text = $"{countE} People";

            //foreach (var m in listManager)
            //{
            //    FUser f = new FUser(deleteUser)
            //    {
            //        _isManager = true,
            //        _UserName = m.User,
            //        _Name = m.Name,
            //        _Phone = m.Phone,
            //        _isOnline = (bool)m.isOnline,
            //        _LinkAvt = m.LinkAVT,
            //        _Status = (int)m.Status
            //    };

            //    ListItems.Add(f); // add to list item
            //    pnListItems.Controls.Add(f); // add to content panel
            //    f.Dock = DockStyle.Top;

            //}

            foreach (var em in listEmployee)
            {
                FUser f = new FUser(deleteUser)
                {
                    _isManager = false,
                    _UserName = em.User,
                    _Name = em.Name,
                    _Phone = em.Phone,
                    _isOnline = (bool)em.isOnline,
                    _LinkAvt = em.LinkAVT,
                    _Status = (int)em.Status
                };

                ListItems.Add(f); // add to list item
                pnListItems.Controls.Add(f); // add to content panel
                f.Dock = DockStyle.Top;

            }
        }

        private void LoadDB() // for load list user from db
        {

            try
            {
                switch (typeU)
                {
                    case 0:  // manager
                        loadManager();
                        break;

                    case 1: // employee
                        break;

                    case 2:  // admin
                        loadAdmin();
                        break;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error :" + e.Message);
            }

        }

        private void LoadForm()
        {

            switch (typeU)
            {
                case 0:  // manager
                    cbbType.SelectedIndex = 2; // only chose text employee
                    typeUser = 1; // only employee
                    cbbType.Enabled = false;

                    cbbStatus.SelectedIndex = 0;
                    btnAddManager.Enabled = false;
                    break;

                case 1: // employee
                    break;

                case 2:  // admin
                    cbbType.SelectedIndex = 0;
                    cbbStatus.SelectedIndex = 0;
                    kryptonBorderEdge1.Hide();
                    break;
            }

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

            dialogProfile dialogProfile = new dialogProfile(0, 0);  // open = 0 -> add , user =0 -> manager 
            dialogProfile.Show();

        }
        private void addStaff_Click(object sender, EventArgs e)
        {

            dialogProfile dialogProfile = new dialogProfile(0, 1); // add - employee
            dialogProfile.Show();
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
            typeUser = 2;
            status = 2;
            LoadForm();
        }

        private void ShowResultFind(String search)
        {
            try
            {
                Tuple<List<Manager>, List<Employee>> result = new AdminController().Search(search);
                List<Manager> listManger = result.Item1;
                List<Employee> listEmployee = result.Item2;

                pnListItems.Controls.Clear();

                FUser title = new FUser();
                title.Dock = DockStyle.Top;
                pnListItems.Controls.Add(title);

                switch (typeU)
                {
                    case 0: // manager
                            //  int countM = listManger.Count;
                        int countE = listEmployee.Count;
                        lbSumManager.Text = $"Unknow";
                        lbSumEmployee.Text = $"{countE} People";
                        lbSumAll.Text = $"{countE} People";

                        ListItems = new CustomList<FUser>(); // add to list item


                        foreach (var em in listEmployee)
                        {
                            FUser f = new FUser(deleteUser)
                            {
                                _isManager = false,
                                _UserName = em.User,
                                _Name = em.Name,
                                _Phone = em.Phone,
                                _isOnline = (bool)em.isOnline,
                                _LinkAvt = em.LinkAVT,
                                _Status = (int)em.Status
                            };

                            ListItems.Add(f); // add to list item
                            pnListItems.Controls.Add(f); // add to content panel
                            f.Dock = DockStyle.Top;

                        }
                        break;

                    case 1://employee
                        break;

                    case 2:


                        int cM = listManger.Count;
                        int cE = listEmployee.Count;
                        lbSumManager.Text = $"{cM} People";
                        lbSumEmployee.Text = $"{cE} People";
                        lbSumAll.Text = $"{cM + cE} People";

                        ListItems = new CustomList<FUser>(); // add to list item
                        //pnListItems.Controls.Clear();

                        foreach (var m in listManger)
                        {
                            FUser f = new FUser(deleteUser)
                            {
                                _isManager = true,
                                _UserName = m.User,
                                _Name = m.Name,
                                _Phone = m.Phone,
                                _isOnline = (bool)m.isOnline,
                                _LinkAvt = m.LinkAVT,
                                _Status = (int)m.Status
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
                                _LinkAvt = em.LinkAVT,
                                _Status = (int)em.Status
                            };

                            ListItems.Add(f); // add to list item
                            pnListItems.Controls.Add(f); // add to content panel
                            f.Dock = DockStyle.Top;

                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
            cbbStatus.SelectedIndex = 0;

            // Đặt thời gian đếm ngược của Timer
            searchTimer.Stop();
            searchTimer.Start();

        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            // Dừng Timer và thực hiện tìm kiếm
            searchTimer.Stop();

            string search = txtFind.Text;
            ShowResultFind(search);
        }

        private void cbbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtFind.Text = "";
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
            //  MessageBox.Show("ok");
        }

        private void cbbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtFind.Text = "";
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

        private void ViewHistory_Click(object sender, EventArgs e)
        {
            dialogHistory dialogHistory = new dialogHistory();
            dialogHistory.ShowDialog();
        }
    }
}
