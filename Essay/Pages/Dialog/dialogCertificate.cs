using DevExpress.XtraEditors;
using Essay.Controllers;
using Essay.Model;
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
    public partial class dialogCertificate : DevExpress.XtraEditors.XtraForm
    {

        private string sid;
        private Certification certificate;

        public dialogCertificate(string sid)
        {
            InitializeComponent();
            this.sid = sid;
            certificate = null;
        }
        public dialogCertificate(Certification cer)
        {
            InitializeComponent();
            this.sid = cer.SID;
            certificate = cer;
        }
        private void dialogCertificate_Load(object sender, EventArgs e)
        {
            if(certificate != null)
            {
                txtID.Enabled = false;
                txtID.Text = certificate.IDCertificate;
                txtName.Text = certificate.Name;
                txtIssueDate.Text = certificate.IssueDate.Value.ToString("yyyy/MM/dd");
                txtExpiryDate.Text = certificate.ExpiryDate.Value.ToString("yyyy/MM/dd");
                txtGrade.Text = certificate.Grade;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNullValue())
            {
                MessageBox.Show("Input must have value", "Invalid Input", MessageBoxButtons.OK);
                return;
            }

            var id = txtID.Text;
            var name = txtName.Text;
            var issue = txtIssueDate.DateTime;
            var exp = txtExpiryDate.DateTime;
            var grade = txtGrade.Text;
            StudentController stc = new StudentController();
            Certification certification = new Certification()
            {
                IDCertificate = id,
                Name = name,
                SID = sid,
                IssueDate = issue,
                ExpiryDate = exp,
                Grade = grade

            };

            if (certificate == null) // add
            {
                if (!stc.AddCertificate(certification)) return;
            }
            else //edit
            {
                if (!stc.UpdateCertificate(certification)) return;
            }

            frmMain.Instance.RequestReload();
            this.Close();
        }


        private bool isNullValue()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtIssueDate.Text == "" || txtExpiryDate.Text == "" || txtGrade.Text == "") return true;
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}