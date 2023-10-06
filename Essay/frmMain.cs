using Essay.Components;
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
using Essay.Components;
using Component;
namespace Essay
{
    public partial class frmMain : KryptonForm
    {


        public frmMain()
        {

            /*frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() != DialogResult.OK)
            {
                Environment.Exit(0);
            }*/
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnTittle = new DraggableKryptonPanel(pnTittle, this);



        }




    }
}
