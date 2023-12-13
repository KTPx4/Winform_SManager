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
using OfficeOpenXml;
using System.IO;
using Essay.Pages.Popup;

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
            // Đăng ký Provider cho Encoding (nếu chưa có)
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Thiết lập giá trị cho LicenseContext
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            InitializeComponent();
            Reload = LoadForm;
            typeU = 2;
            frmMain.Instance.ReloadRequested += Reload;
        }
        public frmMStudent(int TypeUser)
        {
            // Đăng ký Provider cho Encoding (nếu chưa có)
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Thiết lập giá trị cho LicenseContext
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
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
            deleStudent();
        }

        private void deleStudent()
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
        private void deleteCer()
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
        private void btnDelCer_Click(object sender, EventArgs e)
        {

            deleteCer();
        }

        private void btnImportS_Click(object sender, EventArgs e)
        {
            dialogImport dialogImport = new dialogImport();
            dialogImport.ShowDialog();
        }



        private void dgvStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // MessageBox.Show("ok");
                // Kiểm tra xem có dòng nào được chọn không
                if (dgvStudents.CurrentRow?.Index >= 0)
                {
                    deleStudent();
                }
            }
        }

        private void dgvCertificate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                // MessageBox.Show("ok");
                // Kiểm tra xem có dòng nào được chọn không
                if (dgvCertificate.CurrentRow?.Index >= 0)
                {
                    deleteCer();
                }
            }
        }

        private void btnImportC_Click(object sender, EventArgs e)
        {
            dialogImport dialogImport = new dialogImport(false);
            dialogImport.ShowDialog();
        }

        private void btnExportS_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvStudents);
        }
        public static void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                            // Đổ dữ liệu từ DataGridView vào Excel
                            for (int i = 1; i <= dataGridView.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                                worksheet.Cells[1, i].Style.Font.Bold = true;
                            }

                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    if (dataGridView.Columns[j].Name == "Birthday")
                                    {
                                        // Kiểm tra cột birthday và định dạng lại ngày
                                        DateTime dateValue;
                                        if (DateTime.TryParse(dataGridView.Rows[i].Cells[j].Value.ToString(), out dateValue))
                                        {
                                            worksheet.Cells[i + 2, j + 1].Value = dateValue.ToString("yyyy-MM-dd");
                                        }
                                        else
                                        {
                                            worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                                        }
                                    }
                                    else
                                    {
                                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                                    }
                                }
                            }


                            package.SaveAs(new System.IO.FileInfo(sfd.FileName));
                        }

                        MessageBox.Show("Exported successfully!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExportC_Click(object sender, EventArgs e)
        {
            ExportMessage exportMessage = new ExportMessage();
            DialogResult TypeExport = exportMessage.ShowDialog();
            try
            {
                if (TypeExport == DialogResult.Yes) // export all certificate
                {
                    List<Certification> listCer = new StudentController().GetCertifications();
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (ExcelPackage package = new ExcelPackage())
                            {
                                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                                // Đổ dữ liệu từ DataGridView vào Excel
                                for (int i = 1; i <= dgvCertificate.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i].Value = dgvCertificate.Columns[i - 1].HeaderText;
                                    worksheet.Cells[1, i].Style.Font.Bold = true;
                                }
                                int y = 2, x = 1;

                                foreach (var certification in listCer)
                                {
                                    worksheet.Cells[y, 1].Value = certification.IDCertificate;
                                    worksheet.Cells[y, 2].Value = certification.Name;
                                    worksheet.Cells[y, 3].Value = certification.SID;
                                    DateTime dateIss;
                                    if (DateTime.TryParse(certification.IssueDate.ToString(), out dateIss))
                                    {
                                        worksheet.Cells[y, 4].Value = dateIss.ToString("yyyy-MM-dd");
                                    }
                                    if (DateTime.TryParse(certification.ExpiryDate.ToString(), out dateIss))
                                    {
                                        worksheet.Cells[y, 5].Value = dateIss.ToString("yyyy-MM-dd");
                                    }

                                    worksheet.Cells[y++, 6].Value = certification.Grade;

                                }

                                package.SaveAs(new System.IO.FileInfo(sfd.FileName));
                            }

                            MessageBox.Show("Exported successfully!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }


                }
                else if (TypeExport == DialogResult.No)// export Current Student
                {
                    if(dgvCertificate.Rows.Count < 1)
                    {
                        MessageBox.Show("Not Have Certificate to Export!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;

                    }
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (ExcelPackage package = new ExcelPackage())
                            {
                                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                                // Đổ dữ liệu từ DataGridView vào Excel
                                for (int i = 1; i <= dgvCertificate.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i].Value = dgvCertificate.Columns[i - 1].HeaderText;
                                    worksheet.Cells[1, i].Style.Font.Bold = true;
                                }

                                for (int i = 0; i < dgvCertificate.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgvCertificate.Columns.Count; j++)
                                    {
                                        if (dgvCertificate.Columns[j].Name == "Issue Date" || dgvCertificate.Columns[j].Name == "Expiry Date")
                                        {
                                            // Kiểm tra cột birthday và định dạng lại ngày
                                            DateTime dateValue;
                                            if (DateTime.TryParse(dgvCertificate.Rows[i].Cells[j].Value.ToString(), out dateValue))
                                            {
                                                worksheet.Cells[i + 2, j + 1].Value = dateValue.ToString("yyyy-MM-dd");
                                            }
                                            else
                                            {
                                                worksheet.Cells[i + 2, j + 1].Value = dgvCertificate.Rows[i].Cells[j].Value.ToString();
                                            }
                                        }
                                        else
                                        {
                                            worksheet.Cells[i + 2, j + 1].Value = dgvCertificate.Rows[i].Cells[j].Value.ToString();
                                        }
                                    }
                                }


                                package.SaveAs(new System.IO.FileInfo(sfd.FileName));
                            }

                            MessageBox.Show("Exported successfully!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
