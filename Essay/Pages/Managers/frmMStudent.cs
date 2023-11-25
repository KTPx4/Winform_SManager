using Essay.Controllers;
using Essay.Model;
using Essay.Pages.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Essay.Pages.Manager
{
    public partial class frmMStudent : UserControl
    {
        private Action Reload;
        private int typeU; // Dùng để chia quyền khi đăng nhập vào form
                           // 0: Manager
                           // 1:Employee
                           // 2:Admin
        public frmMStudent()
        {
            InitializeComponent();
            Reload = LoadForm;
            typeU = 2;
            frmMain.Instance.ReloadRequested += Reload;
        }
        public frmMStudent(int TypeUser)
        {
            InitializeComponent();
            Reload = LoadForm;
            typeU = TypeUser;
            frmMain.Instance.ReloadRequested += Reload;
        }


        private void frmMStudent_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        public void LoadForm()
        {
            if (typeU == 1)
            {
                grbControls.Enabled = false;
                grbControls.Visible = false;
            }
            var studentController = new StudentController();
            List<Student> students = studentController.GetALL();
            DataTable dataTable = new DataTable();
            dgvStudents.Rows.Clear();
            dgvCertificate.Rows.Clear();

            foreach (Student student in students)
            {

                dgvStudents.Rows.Add(new Object[]
                {
                    student.SID,
                    student.Name,
                    student.Class,
                    student.birthDay,
                    student.Address,
                    student.Phone
                });

            }


        }
        private void showCer()
        {
            var student = dgvStudents.CurrentRow;


            var sid = student.Cells[0].Value;
            if (sid == null) return;

            dgvCertificate.Rows.Clear();

            StudentController stc = new StudentController();
            List<Certification> listCer = stc.GetCertifications(sid.ToString());

            foreach (Certification cer in listCer)
            {

                dgvCertificate.Rows.Add(new Object[]
                {
                    cer.IDCertificate,
                    cer.Name,
                    cer.SID,
                    cer.IssueDate,
                    cer.ExpiryDate,
                    cer.Grade
                });

            }
        }
        private void dgvStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // showCer();
        }

        private void dgvStudents_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            showCer();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dialogStudents dialogStudents = new dialogStudents();
            dialogStudents.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var student = dgvStudents.CurrentRow;
            if (student.Cells[0].Value == null)
            {
                MessageBox.Show("Please chose student!", "Invalid Selection", MessageBoxButtons.OK);
                return;
            }

            var SID = student.Cells[0].Value.ToString();
            var Name = student.Cells[1].Value.ToString();
            var Class = student.Cells[2].Value.ToString();
            var birth = student.Cells[3].Value;
            var address = student.Cells[4].Value.ToString();
            var phone = student.Cells[5].Value.ToString();

            Student st = new Student()
            {
                SID = SID,
                Name = Name,
                Class = Class,
                birthDay = (DateTime)birth,
                Address = address,
                Phone = phone
            };
            dialogStudents dialogStudents = new dialogStudents(st);
            dialogStudents.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var SID = dgvStudents.CurrentRow.Cells[0].Value;
            if (SID == null)
            {
                MessageBox.Show("Please chose student!", "Invalid Selection", MessageBoxButtons.OK);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show($"Do you wat to remove student '{SID}'?", "Confirm Delete", MessageBoxButtons.YesNo))
            {
                StudentController stc = new StudentController();
                stc.Delete(SID.ToString());
                frmMain.Instance.RequestReload();
            }
        }





        private bool isChoseStudent()
        {
            var SID = dgvStudents.CurrentRow.Cells[0].Value;
            if (SID == null)
            {
                MessageBox.Show("Please chose student!", "Invalid Selection", MessageBoxButtons.OK);
                return false;
            }
            return true;

        }
        public bool isChoseCer()
        {
            var Cer = dgvCertificate.CurrentRow.Cells[0].Value;
            if (Cer == null)
            {
                MessageBox.Show("Please chose certificate!", "Invalid Selection", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }


        // Certificate

        private void btnAddCert_Click(object sender, EventArgs e)
        {
            if (!isChoseStudent()) return;
            var SID = dgvStudents.CurrentRow.Cells[0].Value.ToString();
            dialogCertificate dialog = new dialogCertificate(SID);
            dialog.ShowDialog();
        }

        private void btnEditCert_Click(object sender, EventArgs e)
        {
            if (!isChoseStudent()) return;
            if (!isChoseCer()) return;

            var CerID = dgvCertificate.CurrentRow.Cells[0].Value.ToString();
            var CerName = dgvCertificate.CurrentRow.Cells[1].Value.ToString();
            var SID = dgvCertificate.CurrentRow.Cells[2].Value.ToString();
            var Issue = dgvCertificate.CurrentRow.Cells[3].Value;
            var Exp = dgvCertificate.CurrentRow.Cells[4].Value;
            var Grade = dgvCertificate.CurrentRow.Cells[5].Value.ToString();

            Certification cer = new Certification()
            {
                IDCertificate = CerID,
                Name = CerName,
                SID = SID,
                IssueDate = (DateTime)Issue,
                ExpiryDate = (DateTime)Exp,
                Grade = Grade
            };

            dialogCertificate dialog = new dialogCertificate(cer);
            dialog.ShowDialog();

        }

        private void btnDelCer_Click(object sender, EventArgs e)
        {

            if (!isChoseStudent()) return;
            if (!isChoseCer()) return;

            var CerID = dgvCertificate.CurrentRow.Cells[0].Value.ToString();

            if (DialogResult.Yes == MessageBox.Show($"Do you wat to remove Certificate '{CerID}'?", "Confirm Delete", MessageBoxButtons.YesNo))
            {
                StudentController stc = new StudentController();
                stc.DeleteCertificate(CerID.ToString());
                frmMain.Instance.RequestReload();
            }
        }

        private void btnImportS_Click(object sender, EventArgs e)
        {
            dialogImport dialogImport = new dialogImport();
            dialogImport.ShowDialog();
        }
    }
}
