using Component;
using Essay.Components;
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

namespace Essay.Pages.Dialog
{
    public partial class dialogProfile : Form
    {
        public string id { get; set; }
        public string name { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public DateTime birthDay { get; set; }
        
        public int Status { get; set; }

        private int typeUser = 0; // 0 -> manager, 1-> employee
        private int typeOpen = 0; // 0 -> add new, 1-> edit
        private string textStatus = "";
        private int typeBtnAction = 0; // 0 -> active, 1-> block, -1-> delete
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
        // pnControl 94, 296 : 3button
        // 134, 296 : 2button
        void loadForm()
        {
            pnTitle = new DraggablePanel(pnTitle, this);
            if (typeOpen == 0) // type add new profile
            {
                pnControl.Location = new Point(144, 296);
                btnAction.Hide();
                btnEdit.Hide();
                pnStatus.Hide();
                pnGroupTxt.Enabled = true;

                if(typeUser == 0)
                {
                    // action add manager
                }
                else if(typeUser == 1)
                {
                    // action add employee
                }
            }
            else if (typeOpen == 1 && typeUser == 0) // type edit profile and show button action if manager
            {


                pnControl.Location = new Point(94, 296);
                btnAction.Show();
                btnEdit.Show();

                //fill textbox
                txtID.Text = id;
                txtName.Text = name;
                txtPass.Text = password;
                txtPhone.Text = phone;
                txtUser.Text = user;
                txtDate.Value = birthDay;

                if (Status == 0)
                {
                    textStatus = "Active";
                    btnAction.Text = "Block";
                    typeBtnAction = 1; // action block
                }
                else if (Status == 1)
                {
                    textStatus = "Blocked";
                    btnAction.Text = "Active";
                    typeBtnAction = 0; // action active


                }
                else
                {
                    textStatus = "Deleted";
                    btnAction.Text = "Restore";
                    typeBtnAction = 0; // action active

                }
                txtStatus.Text = textStatus;

            }
            else if (typeOpen == 1) // edit for each account
            {
                pnControl.Location = new Point(144, 296);
                btnAction.Hide();
                btnEdit.Show();

                //fill textbox
                txtID.Text = id;
                txtName.Text = name;
                txtPass.Text = password;
                txtPhone.Text = phone;
                txtUser.Text = user;
                txtDate.Text = birthDay.ToString();


            }
        }

        private void dialogProfile_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

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
                        string newFileName = fileName + "_id0101" + fileExtension;

                        string destinationFilePath = Path.Combine(destinationFolder, newFileName);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnGroupTxt.Enabled = true;
        }
    }
}
