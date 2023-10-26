using Essay.Components;
using Krypton.Toolkit;
using System;
using System.Linq;

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
        public String _UID { get; set; }
        public String _Name { get; set; }
        public String _Phone { get; set; }
        public bool _isOnline { get; set; }
        public string _LinkAvt { get; set; }



        Action<FUser> DeleteUser;

        public FUser()
        {
            InitializeComponent();
            DeleteUser = null;


            _UID = "";
            _Name = "";
            _Phone = "";
            _isOnline = false;
            _LinkAvt = "";
            _isManager = false;
        }

        public FUser(Action<FUser> deleteU, string iD)
        {
            InitializeComponent();
            DeleteUser = deleteU;
            _UID = iD;
            _Name = "";
            _Phone = "";
            _isOnline = false;
            _LinkAvt = "";
            _isManager = false;

        }
        public FUser(Action<FUser> deleteU, bool isManager, string iD, string name, string phone, bool isOnline, string link)
        {
            InitializeComponent();
            DeleteUser = deleteU;
            _UID = iD;
            _Name = name;
            _Phone = phone;
            _isOnline = isOnline;
            _LinkAvt = link;
            _isManager = isManager;
        }

        private void loadForm()
        {
            pnID.Location = new Point(Variables._X_Item_User, pnID.Location.Y);
            pnID.BackColor = _isManager ? Variables._Back_Items_Manager : Variables._Back_Items_User;
            lbID.Text = _UID;
            lbName.Text = _Name;
            lbSdt.Text = _Phone;
            lbStatus.Text = _isOnline ? "Online" : "Offline";
            lbStatus.ForeColor = _isOnline ? Color.Blue : Color.Red;

            // change img 
            if (_LinkAvt != "")
            {
                ptbAvt.ImageLocation = $"{Variables._pathAvt}/{_LinkAvt}";

            }
        }
        private void User_Load(object sender, EventArgs e)
        {
            // pnID.BackColor = GenerateRandomColor();

            loadForm();


        }




        // Action




        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser(this);
        }

        private Color GenerateRandomColor()
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            return randomColor;
        }






    }
}
