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
    public partial class dialogStudents : DevExpress.XtraEditors.XtraForm
    {
        private bool isEdit = false;
        private Student student;
        public dialogStudents()
        {
            InitializeComponent();
            student = null;
        }
        public dialogStudents(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void dialogStudents_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                txtID.Enabled = false;
                txtID.Text = student.SID;
                txtName.Text = student.Name;
                txtClass.Text = student.Class;
                txtAddress.Text = student.Address;
                txtBirth.Text = student.birthDay.Value.ToString("yyyy/MM/dd");
                txtPhone.Text = student.Phone;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNull())
            {
                MessageBox.Show("Input must have not null!", "Invalid Input", MessageBoxButtons.OK);
                return;
            }

            StudentController stc = new StudentController();

            var id = txtID.Text;
            var name = txtName.Text;
            var Class = txtClass.Text;
            var birth = txtBirth.DateTime;
            var address = txtAddress.Text;
            var phone = txtPhone.Text;
            Student st = new Student()
            {
                SID = id,
                Name = name,
                Class = Class,
                birthDay = birth,
                Address = address,
                Phone = phone
            };

            if (student == null) // add new
            {

                if (!stc.Add(st))
                {
                    return;
                }

            }
            else // edit
            {
                if (!stc.Update(st))
                {
                    return;
                }
            }

            frmMain.Instance.RequestReload();
            this.Close();
        }
        private bool CheckNull()
        {
            if (txtID.Text == "" || txtName.Text == "" || txtClass.Text == "" || txtBirth.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
                return false;

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBirth_EditValueChanged(object sender, EventArgs e)
        {
        }
    }
}