using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay.Pages.Dialog
{
    public partial class PopupMessage : KryptonForm
    {
        private Action _btnAction1;
        private Action _btnAction2;
        private Action _btnAction3;

        public String Caption {  get; set; }
        public String Message { get; set; }


        public PopupMessage()
        {
            InitializeComponent();
        }

        private void PopupMessage_Load(object sender, EventArgs e)
        {

        }

        public  void addActionBtn1(Action act)
        {
            _btnAction1 = act;
        }
        public  void addActionBtn2(Action act)
        {
            _btnAction2 = act;

        }
        public  void addActionBtn3(Action act)
        {
            _btnAction3 = act;

        }





        private void btn1_Click(object sender, EventArgs e)
        {
            _btnAction1();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            _btnAction2();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _btnAction3();
        }
    }
}
