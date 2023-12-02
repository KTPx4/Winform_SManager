using Components;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay.Pages.Popup
{
    public partial class BoxMessageImport : DevExpress.XtraEditors.XtraForm
    {
        private DataTable Added;
        private DataTable Reject;
        public BoxMessageImport(DataTable Added, DataTable Reject)
        {
            InitializeComponent();
            this.Added = Added;
            this.Reject = Reject;
        }



        private void buttonBorder1_MouseHover(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.DimGray;
            btnOk.ForeColor = Color.White;
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackColor = Color.Transparent;
            btnOk.ForeColor = Color.Black;
        }

        private void BoxMessage_Load(object sender, EventArgs e)
        {
            pnTitle = new DraggablePanel(pnTitle, this);
            dgvAdded.DataSource = Added;
            dgvReject.DataSource = Reject;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}