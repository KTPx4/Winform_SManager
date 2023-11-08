using Essay.Components;
using Essay.Controllers;
using Essay.Model;
using Essay.Pages.Dialog;
using Krypton.Toolkit;
using System;
using System.IO;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Essay.Pages.Items
{
    public partial class FUser : UserControl
    {
        /*
         [ID] varchar(50) Primary key,

             [Name] varchar(250),
             [User] varchar(50) ,
             [Pass] varchar(20) ,	
             birthDay date,
             Phone varchar(10),
             [Status] bit,	
             isDelete bit,
             LinkAVT Text


            pnMenuNav.BackgroundImage = Properties.Resources.icons8_double_left_16;
         */
        public bool _isManager { get; set; }
        public String _UserName { get; set; }
        public String _Name { get; set; }
        public String _Phone { get; set; }
        public bool _isOnline { get; set; }
        public string _LinkAvt { get; set; }
        public int _Status { get; set; }

        private bool isTile = false;


        Action<FUser> DeleteUser;

        public FUser()
        {
            InitializeComponent();
            DeleteUser = null;


            _UserName = "";
            _Name = "";
            _Phone = "";
            _isOnline = false;
            _LinkAvt = "";
            _isManager = false;
            isTile = true;
        }

        public FUser(Action<FUser> deleteU, string iD)
        {
            InitializeComponent();
            DeleteUser = deleteU;
            _UserName = iD;
            _Name = "";
            _Phone = "";
            _isOnline = false;
            _LinkAvt = "";
            _isManager = false;

        }

        public FUser(Action<FUser> deleteU)
        {
            InitializeComponent();
            DeleteUser = deleteU;

        }

        private void CreateTitle()
        {
            pnID.Location = new Point(Variables._X_Item_User, pnID.Location.Y);
            pnID.BackColor = Color.Transparent;
            lbID.Text = "User";
            lbID.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Segoe UI, 11.25pt, style=Bold
            lbID.ForeColor = Color.White;

            lbName.Text = "Name";
            lbName.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Segoe UI, 11.25pt, style=Bold
            lbName.ForeColor = Color.White;

            lbSdt.Text = "Phone";
            lbSdt.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Segoe UI, 11.25pt, style=Bold
            lbSdt.ForeColor = Color.White;

            lbStatus.Text = "Status";
            lbStatus.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Segoe UI, 11.25pt, style=Bold
            lbStatus.ForeColor = Color.White;
            ptbAvt.Hide();
            pnButton.Hide();

        }

        private void loadForm()
        {
            pnID.Location = new Point(Variables._X_Item_User, pnID.Location.Y);
            pnID.BackColor = _isManager ? Variables._Back_Items_Manager : Variables._Back_Items_User;
            lbID.Text = _UserName;
            lbName.Text = _Name;
            lbSdt.Text = _Phone;
            lbStatus.Text = _isOnline ? "Online" : "Offline";
            lbStatus.ForeColor = _isOnline ? Color.Blue : Color.Red;

            // change img 
            if (_LinkAvt != "")
            {
                if (File.Exists(_LinkAvt))
                {
                    ptbAvt.ImageLocation = $"{Variables._pathAvt}/{_LinkAvt}"; // img/avt/husky1.png
                }

            }

            switch (_Status)
            {
                case -1:
                    btnDel.Hide();
                    btnBlock.Hide();
                    btnRestore.Show();
                    break;

                case 0:
                    btnRestore.Hide();
                    btnDel.Show();
                    btnBlock.Show();
                    break;

                case 1:
                    btnDel.Show();
                    btnBlock.Hide();
                    btnRestore.Show();
                    break;
            }

        }


        private void User_Load(object sender, EventArgs e)
        {

            if (!isTile)
            {
                loadForm();
            }
            else
            {
                CreateTitle();
            }


        }




        // Action

        private void deleteUser()
        {
            String userName = _UserName;
            if (!new AdminController().DeleteUser(userName))
            {
                MessageBox.Show("Error when Delete\nCheck code again!", "Error Delete", MessageBoxButtons.OK);
            }

        }

        private void lockUser()
        {
            String userName = _UserName;
            if (!new AdminController().LockUser(userName))
            {
                MessageBox.Show("Error when Lock\nCheck code again!", "Error Lock Account", MessageBoxButtons.OK);
            }
        }

        private void showUser()
        {
            String userName = _UserName;
            if (!new AdminController().isExistsUser(userName))
            {
                MessageBox.Show("User is NOT EXISTS in Database", "Error View Account", MessageBoxButtons.OK);
                return;
            }

            dynamic m = null;

            if (_isManager)
            {
                m = new ManagerController().GetByUser(userName);
            }
            else
            {
                m = new EmployeeController().GetByUser(userName);
            }

            dialogProfile pf = new dialogProfile(1, _isManager ? 0 : 1)
            {
                id = (int)m.ID,
                name = m.Name,
                user = m.User,
                password = m.Pass,
                phone = m.Phone,
                birthDay = (DateTime)m.birthDay,
                linkAvt = m.LinkAVT,
                Status = (int)m.Status
            };

            pf.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you wan to DELETE User '{_UserName}' ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // MessageBox.Show("Delete");
                deleteUser();
                DeleteUser(this);
            }
            return;

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you wan to LOCK User '{_UserName}' ?", "Confirm Lock Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // MessageBox.Show("Delete");
                lockUser();
                DeleteUser(this);
            }
            return;
        }

        private void btnViews_Click(object sender, EventArgs e)
        {
            showUser();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you wan to RESTORE User '{_UserName}' ?", "Confirm Lock Account", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!new AdminController().RestoreUser(_UserName))
                {

                    MessageBox.Show("Error when restore, try again", "Error Restore Account", MessageBoxButtons.OK);
                    return;
                }

                frmMain.Instance.RequestReload();
            }

        }


        private void ptbAvt_MouseHover(object sender, EventArgs e)
        {
            ptbAvt.BackColor = Color.Pink;
        }

        private void ptbAvt_MouseLeave(object sender, EventArgs e)
        {
            ptbAvt.BackColor = Color.Transparent;

        }

        private void Picture_hover(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            button.BackColor = Color.Ivory;

        }

        private void Picture_leave(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            button.BackColor = Color.Transparent;

        }
        private void ViewHistory()
        {
            dialogHistory dialogHistory = new dialogHistory(_UserName, _isManager);
            dialogHistory.Show();
        }
        private void ptbAvt_Click(object sender, EventArgs e)
        {
            ViewHistory();
        }
    }
}
