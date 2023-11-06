using Components;
using DevExpress.Office.Drawing;
using Essay.Components;
using Essay.Controllers;
using Essay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Essay.Pages.Dialog
{
    public partial class dialogProfile : Form
    {
        public int id { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public DateTime birthDay { get; set; }
        public string linkAvt { get; set; }
        public int Status { get; set; }

        private Action<String, String> updateProfile;
        private bool changIMG = false;
        private String nextnameIMG;
        private String fullNameIMG = "user.png";
        private String pathIMG;
        private int typeUser = 0; // 0 -> manager, 1-> employee
        private int typeOpen = 0; // 0 -> add new, 1-> edit , 2-> update profile
        private string textStatus = "";
        private int typeBtnAction = 0; // 0 -> active, 1-> block, -1-> delete
        private static String textPhone = "";

        public dialogProfile()
        {
            InitializeComponent();
            typeOpen = 0;
        }
        // if add new -> type open = 0, type user = 1-> add employee, 0-> add manager
        // if edit -> type open = 1, type user 1-> only edit their info
        //                           type manager 0-> can blocl / unblock account
        public dialogProfile(int typeOpen, int typeUser)
        {
            InitializeComponent();
            this.typeOpen = typeOpen;
            this.typeUser = typeUser;
        }

        public dialogProfile(String Username, int typeUser) // for edit user
        {
            InitializeComponent();
            typeOpen = 1; // edit
            this.typeUser = typeUser;              // 
            this.user = Username;
            LoadInfor(Username);
            // get type user by load from data 
        }

        public dialogProfile(String Username, int typeOpen, int typeUser, Action<String, String> update) // for edit user
        {
            InitializeComponent();


            this.typeOpen = typeOpen; // 2-> update profile
            this.typeUser = typeUser;
            this.user = Username;

            LoadInfor(Username);

            updateProfile = update;

            // get type user by load from data 
        }


        private void LoadInfor(String user) // load infor mation and type user to variable
        {

            try
            {

                if (typeUser == 0)
                {
                    //public int id { get; set; }
                    //public string name { get; set; }
                    //public string user { get; set; }
                    //public string password { get; set; }
                    //public string phone { get; set; }
                    //public DateTime birthDay { get; set; }
                    //public string linkAvt { get; set; }
                    //public int Status { get; set; }
                    Manager m = new ManagerController().GetFromUser(user);
                    if (m != null)
                    {
                        id = m.ID;
                        this.name = m.Name;
                        this.user = m.User;
                        password = m.Pass;
                        phone = m.Phone;
                        birthDay = (DateTime)m.birthDay;
                        Status = (int)m.Status;
                        linkAvt = m.LinkAVT;
                    }
                }
                else if (typeUser == 1)
                {
                    Employee m = new EmployeeController().GetFromUser(user);
                    if (m != null)
                    {
                        id = m.ID;
                        name = m.Name;
                        this.user = m.User;
                        password = m.Pass;
                        phone = m.Phone;
                        birthDay = (DateTime)m.birthDay;
                        Status = (int)m.Status;
                        linkAvt = m.LinkAVT;
                    }
                }
                else if (typeUser == 2)
                {
                    Admin m = new AdminController().GetFromUser(user);
                    if (m != null)
                    {
                        id = m.ID;
                        this.name = m.Name;
                        this.user = m.User;
                        password = m.Password;
                        phone = "";

                        linkAvt = m.LinkAVT;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error When loading Infor: " + e.Message);
            }


            // action load data to variable



        }

        void loadForm()
        {
            try
            {

                pnTitle = new DraggablePanel(pnTitle, this); // move form
                txtStatus.Enabled = false; // hide textbox status

                //get next ID
                if (typeUser == 0)
                {
                    nextnameIMG = "Manager_" + new ManagerController().NextID().ToString();
                    this.BackColor = Color.SlateGray;
                }
                else if (typeUser == 1)
                {
                    nextnameIMG = "Employee_" + new EmployeeController().NextID().ToString();
                    this.BackColor = Color.Gray;
                }
                else
                {
                    nextnameIMG = "Admin_" + new AdminController().NextID().ToString();
                    this.BackColor = Color.SlateGray;

                }


                // action for type open

                if (typeOpen == 0) // type add new profile
                {
                    // pnControl 94, 296 : 3button
                    // 144, 296 : 2button
                    pnControl.Location = new Point(144, 296);


                    //btnAction.Hide();
                    btnEdit.Hide();
                    pnStatus.Hide();
                    pnGroupTxt.Enabled = true;


                }
                else if (typeOpen == 1 || typeOpen == 2) // type edit profile and show button action if manager
                {
                    fullNameIMG = linkAvt;

                    // pnControl 94, 296 : 3button
                    // 134, 296 : 2button


                    //fill textbox
                    // txtID.Text = id;
                    txtName.Text = name;
                    txtPass.Text = password;
                    txtPhone.Text = phone;
                    txtUser.Text = user;
                    txtDate.DateTime = birthDay;
                    try
                    {
                        String p = $"{Variables._pathAvt}/{linkAvt}";
                        if (File.Exists(p))
                        {
                            // Tệp tồn tại
                            // Thực hiện xử lý tương ứng\
                            using (FileStream fs = new FileStream(p, FileMode.Open, FileAccess.Read))
                            {
                                btnProfile.StateCommon.Back.Image = new Bitmap(System.Drawing.Image.FromStream(fs));
                            }
                            //btnProfile.StateCommon.Back.Image = new Bitmap(System.Drawing.Image.FromFile(p));
                            // btnProfile.StateCommon.Back.Image = System.Drawing.Image.FromFile(p);
                        }

                        // btnProfile.StateCommon.Back.Image = System.Drawing.Image.FromFile($"{Variables._pathAvt}/{linkAvt}");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Load Avatar: " + ex.Message);
                    }

                    //    MessageBox.Show(typeUser.ToString());
                    if (typeUser == 0) // check type user can use button block/unblock
                    {
                        //pnControl.Location = new Point(94, 296);


                        //  btnAction.Show();
                        btnEdit.Show();
                        if (Status == 0)
                        {
                            textStatus = "Active";
                            //  btnAction.Text = "Block";
                            typeBtnAction = 1; // action block
                        }
                        else if (Status == 1)
                        {
                            textStatus = "Blocked";
                            //   btnAction.Text = "Active";
                            typeBtnAction = 0; // action active


                        }
                        else
                        {
                            textStatus = "Deleted";
                            //  btnAction.Text = "Restore";
                            typeBtnAction = 0; // action active

                        }
                    }
                    else if (typeUser == 1)
                    {
                        pnControl.Location = new Point(144, 296);
                        //  btnAction.Hide();
                        btnEdit.Show();
                    }
                    else
                    {
                        txtDate.Enabled = false;
                        txtPhone.Enabled = false;
                        txtStatus.Enabled = false;
                    }

                    txtStatus.Text = textStatus;


                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }


        }

        private void dialogProfile_Load(object sender, EventArgs e)
        {

            loadForm();
        }

        //change avt
        private void btnProfile_Click(object sender, EventArgs e)
        {
            changIMG = true;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        string destinationFolder = $"{Variables._pathAvt}"; // Thư mục đích

                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                        string fileExtension = Path.GetExtension(selectedFilePath);

                        if (typeOpen == 0) // ở dạng thêm mới, khi thay đổi avatar, nó sẽ tự tạo một tên ảnh mới là tên tiếp theo của ID, 
                        {
                            fullNameIMG = nextnameIMG + fileExtension; // EX: Employee_3.png

                            pathIMG = $"{Variables._pathAvt}/" + fullNameIMG; // EX: Img/Avt/Employee_3.png
                        }
                        else
                        {
                            // Khi ở dạng mở chỉnh sửa, và thay đổi ảnh, nó sẽ tạo ra 1 ảnh tạm, ví dụ 1_Employee_3.png
                            // Khi người dùng nhấn Cancel thì nó sẽ xóa ảnh 1_Employee_3.png mà không ảnh hưởng gì ảnh cũ
                            // Còn nếu nhấn Save, thì dưới Method ActionEdit sẽ xử lý Xóa ảnh cũ 'Employee_3.png', sau đó đổi tên 1_Employee_3.png thành Employee_3.png

                            fullNameIMG = "1_" + linkAvt;

                            pathIMG = $"{Variables._pathAvt}/" + fullNameIMG;
                        }


                        string destinationFilePath = Path.Combine(destinationFolder, fullNameIMG);


                        File.Copy(selectedFilePath, destinationFilePath, true);

                        using (FileStream fs = new FileStream(destinationFilePath, FileMode.Open, FileAccess.Read))
                        {
                            btnProfile.StateCommon.Back.Image = new Bitmap(System.Drawing.Image.FromStream(fs));
                        }


                        // MessageBox.Show("Tệp hình ảnh đã được sao chép vào thư mục 'img' với tên mới: " + newFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }





            //MessageBox.Show("", "", MessageBoxButtons.YesNoCancel);
        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnGroupTxt.Enabled = true;
            if (typeUser == 2)
            {
                txtDate.Enabled = false;
                txtPhone.Enabled = false;
                txtStatus.Enabled = false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckShowPass_CheckedChanged(object sender, EventArgs e)
        {

            txtPass.PasswordChar = ckShowPass.Checked ? '\0' : '*';

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                textPhone = "";
                return;
            }

            if (int.TryParse(txtPhone.Text, out int number))
            {
                textPhone = txtPhone.Text;
            }
            else
            {
                txtPhone.Text = textPhone;
                txtPhone.Select(txtPhone.Text.Length, 0);
            }



        }

        private bool isCanAdd()
        {
            if (typeUser == 2)
            {
                if (txtName.Text == "" || txtPass.Text == "" || txtUser.Text == "")
                {
                    MessageBox.Show("Input have empty. Please input full values!", "Null Value", MessageBoxButtons.OK);
                    return false;
                }

            }
            else if (txtName.Text == "" || txtPass.Text == "" || txtUser.Text == "" || txtPhone.Text == "" || txtDate.Text == "")
            {
                MessageBox.Show("Input have empty. Please input full values!", "Null Value", MessageBoxButtons.OK);
                return false;
            }
            else if (!int.TryParse(txtPhone.Text, out int number))
            {
                MessageBox.Show("Phone is not valid!", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            else if (txtPhone.Text.Length > 10)
            {
                MessageBox.Show("Phone must < 10 number!", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }
            else if (txtPass.Text.Length < 5)
            {
                MessageBox.Show("Password must at least 5 character!", "Invalid Input", MessageBoxButtons.OK);
                return false;
            }



            return true;
        }
        private void ActionAdd()
        {
            if (typeUser == 0)
            {
                // action add manager
                // action add employee
                Manager em = new Manager()
                {
                    Name = txtName.Text,
                    User = txtUser.Text,
                    Pass = txtPass.Text,
                    Phone = txtPhone.Text,
                    birthDay = txtDate.DateTime,
                    Status = 0, // active,
                    isOnline = false,
                    LinkAVT = fullNameIMG

                };
                if (!new ManagerController().Add(em))
                {
                    MessageBox.Show("User is exists or Error when Add. Try it Again!", "Error Add", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (typeUser == 1)
            {

                // action add employee
                Employee em = new Employee()
                {
                    Name = txtName.Text,
                    User = txtUser.Text,
                    Pass = txtPass.Text,
                    Phone = txtPhone.Text,
                    birthDay = txtDate.DateTime,
                    Status = 0, // active,
                    isOnline = false,
                    LinkAVT = fullNameIMG

                };
                if (!new EmployeeController().Add(em))
                {
                    MessageBox.Show("User is exists or Error when Add. Try it Again!", "Error Add", MessageBoxButtons.OK);
                    return;
                }
            }
        }


        // Khi người dùng nhấn Cancel thì nó sẽ xóa ảnh 1_Employee_3.png mà không ảnh hưởng gì ảnh cũ
        // Còn nếu nhấn Save, thì dưới Method ActionEdit sẽ xử lý Xóa ảnh cũ 'Employee_3.png', sau đó đổi tên 1_Employee_3.png thành Employee_3.png
        private void ActionEdit()
        {
            if (changIMG)
            {
                try
                {
                    if (File.Exists(pathIMG))
                    {
                        if (File.Exists($"{Variables._pathAvt}/{linkAvt}"))
                        {
                            File.Delete($"{Variables._pathAvt}/{linkAvt}");
                        }
                        File.Move(pathIMG, $"{Variables._pathAvt}/{linkAvt}");
                        pathIMG = $"{Variables._pathAvt}/{linkAvt}";

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Delete File: " + ex.Message);
                }
            }

            switch (typeUser)
            {
                case 0:
                    Manager m = new Manager()
                    {
                        ID = id,
                        Name = txtName.Text,
                        User = txtUser.Text,
                        Pass = txtPass.Text,
                        Phone = txtPhone.Text,
                        birthDay = txtDate.DateTime,
                        LinkAVT = linkAvt
                    };

                    if (!new ManagerController().Update(m))
                    {
                        MessageBox.Show("Error when Update. Try it Again!", "Error Add", MessageBoxButtons.OK);

                    }
                    break;
                case 1:
                    Employee e = new Employee()
                    {
                        ID = id,
                        Name = txtName.Text,
                        User = txtUser.Text,
                        Pass = txtPass.Text,
                        Phone = txtPhone.Text,
                        birthDay = txtDate.DateTime,
                        LinkAVT = linkAvt
                    };

                    if (!new EmployeeController().Update(e))
                    {
                        MessageBox.Show("Error when Update. Try it Again!", "Error Add", MessageBoxButtons.OK);

                    }
                    break;

                case 2:
                    Admin a = new Admin()
                    {
                        ID = id,
                        Name = txtName.Text,
                        User = txtUser.Text,
                        Password = txtPass.Text,
                        LinkAVT = linkAvt
                    };

                    if (!new AdminController().Update(a))
                    {
                        MessageBox.Show("Error when Update Admin. Try it Again!", "Error Add", MessageBoxButtons.OK);

                    }
                    break;

            }

        }

        private void ActionEditProfile()
        {
            ActionEdit();
            updateProfile(txtUser.Text, pathIMG); // update profile at main
        }

        // Button save Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isCanAdd())
            {
                return;
            }
            switch (typeOpen)
            {
                case 0: // add new
                    ActionAdd();
                    break;

                case 1: // edit
                    ActionEdit();
                    break;

                case 2: // edit - update profile , Tương tự như edit, nhưng thêm cái là sẽ sửa thông tin ở Main nửa, nên dùng Action để update trong frmMain
                    ActionEditProfile();
                    break;
            }

            frmMain.Instance.RequestReload();
            this.Close();
        }

        // exist form
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (changIMG) // if have change picture -> remove if exists
            {
                try
                {
                    if (File.Exists(pathIMG))
                    {
                        File.Delete(pathIMG);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Delete File: " + ex.Message);
                }

            }
            this.Close();
        }

        // button lock / unlock
        private void btnAction_Click(object sender, EventArgs e)
        {
            if (typeUser == 0)
            {
                // action add manager
            }
            else if (typeUser == 1)
            {
                // action add employee
            }
        }
    }
}
