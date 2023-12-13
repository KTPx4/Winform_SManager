using DevExpress.CodeParser;
using DevExpress.DataAccess.Native.Excel;
using DevExpress.XtraEditors;
using Essay.Controllers;
using Essay.Model;
using Essay.Pages.Popup;
using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Essay.Pages.Dialog
{
    public partial class dialogImport : DevExpress.XtraEditors.XtraForm
    {
        private bool isImportStudent = true;
        private static List<DataRow> ListRow = new List<DataRow>();
        private static DataTable dt = new DataTable();

        public dialogImport()
        {
            // Đăng ký Provider cho Encoding (nếu chưa có)
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Thiết lập giá trị cho LicenseContext
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


            InitializeComponent();
            isImportStudent = true;

        }
        public dialogImport(bool isImportStudent)
        {
            // Đăng ký Provider cho Encoding (nếu chưa có)
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            // Thiết lập giá trị cho LicenseContext
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();
            this.isImportStudent = isImportStudent;
        }


        private void dialogImport_Load(object sender, EventArgs e)
        {
            if(isImportStudent)
            {
                this.Text = "Import Student";
            }
            else
            {
                this.Text = "Import Certificate";

            }

        }



        private void LoadList()
        {
            int line = 1;

            dt.Rows.Clear();

            foreach (DataRow originalRow in ListRow)
            {
                DataRow newRow = dt.NewRow();
                newRow.ItemArray = originalRow.ItemArray.Clone() as object[];

                // Cập nhật giá trị cho cột đầu tiên (index 0)
                newRow[0] = line++;

                dt.Rows.Add(newRow);
            }

            dgvImport.DataSource = dt;
        }

        private string ConvertToDateFormat(string inputDate, string sourceFormat, string targetFormat)
        {
            if (DateTime.TryParseExact(inputDate, sourceFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                // Sử dụng phương thức Date để loại bỏ thông tin giờ
                return parsedDate.Date.ToString(targetFormat);
            }

            return inputDate;
        }

        private void ReadExcelFile(string filePath)
        {


            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                dt.Columns.Add("#");

                // Đọc tiêu đề (dòng đầu tiên) và thêm cột vào DataTable
                for (int i = 1; i <= worksheet.Dimension.Columns; i++)
                {
                    dt.Columns.Add(worksheet.Cells[1, i].Value.ToString());
                }

                // Đọc dữ liệu từ các dòng còn lại và thêm vào DataTable
                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    DataRow newRow = dt.NewRow();

                    bool hasValue = false;
                    for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                    {
                        object cellValue = worksheet.Cells[row, col].Value;
                        //student
                        if (DateTime.TryParse(cellValue.ToString(), out DateTime dateValue) && col == 4 && isImportStudent)
                        {
                            // Nếu giá trị là một ngày, sử dụng định dạng mong muốn
                            newRow[col] = dateValue.ToString("yyyy-MM-dd");
                        }
                        //Ceritficate
                        else if(!isImportStudent && DateTime.TryParse(cellValue.ToString(), out DateTime dateValues) && (col == 4 || col == 5 ))
                        {
                            newRow[col] = dateValues.ToString("yyyy-MM-dd");
                        }    
                        else
                        {
                            // Nếu không phải ngày, giữ nguyên giá trị
                            newRow[col] = cellValue;
                        }

                        if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                        {
                            hasValue = true;
                        }
                    }

                    if (hasValue)
                    {
                        ListRow.Add(newRow);
                    }
                }


                // Hiển thị dữ liệu trong DataGridView
                LoadList();
                // dgvImport.DataSource = dt;
            }
        }


        private void ReadCsvFile(string filePath)
        {
            using (TextFieldParser parser = new TextFieldParser(filePath, Encoding.UTF8))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                bool isFirstRow = true;

                dt.Columns.Add("#");
                int line = 1;

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields != null)
                    {
                        if (isFirstRow)
                        {
                            foreach (string field in fields)
                            {
                                dt.Columns.Add(field);
                            }

                            isFirstRow = false;
                        }
                        else
                        {
                            DataRow newRow = dt.NewRow();
                            bool hasValue = false;

                            for (int i = 0; i < fields.Length; i++)
                            {
                                if (DateTime.TryParse(fields[i].ToString(), out DateTime dateValue) && i == 3 && isImportStudent)
                                {
                                    // Nếu giá trị là một ngày, sử dụng định dạng mong muốn
                                    newRow[i + 1] = dateValue.ToString("yyyy-MM-dd");
                                } 
                                //Ceritficate
                                else if (!isImportStudent && DateTime.TryParse(fields[i].ToString(), out DateTime dateValues) && (i == 3 || i == 4))
                                {
                                    newRow[i + 1] = dateValues.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    newRow[i + 1] = fields[i];
                                }


                                if (!string.IsNullOrEmpty(fields[i]))
                                {
                                    hasValue = true;
                                }
                            }

                            if (hasValue)
                            {
                                ListRow.Add(newRow);
                            }
                        }
                    }
                }

                LoadList();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel, Csv|*.csv;*.xlsx";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the path of specified file
                        string filePath = openFileDialog.FileName;
                        txtUri.Text = filePath;

                        var fileStream = openFileDialog.OpenFile();
                        dgvImport.DataSource = null;
                        dgvImport.Rows.Clear();
                        dgvImport.Columns.Clear();

                        dt = new DataTable();
                        ListRow = new List<DataRow>();

                        if (System.IO.Path.GetExtension(filePath) == ".xlsx")
                        {
                            if (isImportStudent)
                            {
                                
                            }

                            ReadExcelFile(filePath);
                        }
                        else if (System.IO.Path.GetExtension(filePath) == ".csv")
                        {
                            ReadCsvFile(filePath);
                        }
                        else
                        {
                            MessageBox.Show("Chỉ hỗ trợ định dạng tệp tin Excel (.xlsx | .csv)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File: " + ex);
            }


        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvImport.Rows.Count == 0)
            {
                MessageBox.Show("Please Chose Row To Delete", "Error Delete", MessageBoxButtons.OK);
                return;
            }

            int indexCurrentRow = dgvImport.CurrentRow.Index;
            if (indexCurrentRow < 0)
            {
                MessageBox.Show("Please Chose Row To Delete", "Error Delete", MessageBoxButtons.OK);
                return;
            }
            // dgvImport.Rows.RemoveAt(indexCurrentRow);
            ListRow.RemoveAt(indexCurrentRow);
            foreach (DataRow row in ListRow)
            {
                // MessageBox.Show(row[0].ToString() + "_" + row[1].ToString());

            }
            //   MessageBox.Show(ListRow[0][1].ToString());
            LoadList();


        }
        private bool IsColumnHeaderStudent(DataTable dt)
        {
            // Danh sách các cột mong muốn
            List<string> expectedColumns = new List<string> { "#", "SID", "Name", "Class", "Birth Day", "Address", "Phone" };
            int i = 0;
            foreach(DataColumn col in dt.Columns)
            {
                if(!col.ColumnName.Contains(expectedColumns[i++]))
                {
                    return false;
                }    
            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ListRow.Count < 1)
            {
                MessageBox.Show("Not Have Student!", "Null Value", MessageBoxButtons.OK);
                return;
            }

       
           
            try
            {
                DataTable Added = dt.Clone(); // Tạo bảng mới với cấu trúc giống với bảng hiện tại
                DataTable Reject = dt.Clone(); // Tạo bảng mới với cấu trúc giống với bảng hiện tại

                Added.Rows.Clear();
                Reject.Rows.Clear();

                StudentController stc = new StudentController();

                int line = 1;

                bool notStudent = !IsColumnHeaderStudent(dt);

                foreach (DataRow row in ListRow)
                {
                    // Tạo một hàng mới cho mỗi bảng
                    DataRow newRowAdded = Added.NewRow();
                    DataRow newRowReject = Reject.NewRow();

                    row[0] = line++;
                    newRowAdded.ItemArray = row.ItemArray.Clone() as object[];
                    newRowReject.ItemArray = row.ItemArray.Clone() as object[];

                    if (isImportStudent) // student
                    {
                        var SID = row[1]?.ToString() ?? "";
                        var Name = row[2]?.ToString() ?? "";
                        var Class = row[3]?.ToString() ?? "";
                        var birth = row[4] ?? "";
                        var Address = row[5]?.ToString() ?? "";
                        var phone = row[6]?.ToString() ?? "";



                        // Kiểm tra nếu bất kỳ giá trị nào là null hoặc chuỗi rỗng
                        if (notStudent || string.IsNullOrEmpty(SID) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Class) || string.IsNullOrEmpty(birth.ToString()) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(phone))
                        {
                            Reject.Rows.Add(newRowReject); // Thêm vào bảng Reject nếu có giá trị null hoặc chuỗi rỗng
                        }
                        else
                        {
                            if (stc.isExistsID(SID))
                            {
                                Reject.Rows.Add(newRowReject);
                            }
                            else
                            {
                                Student st = new Student()
                                {
                                    SID = SID,
                                    Name = Name,
                                    Class = Class,
                                    birthDay = DateTime.ParseExact(birth.ToString(), "yyyy-MM-dd", null),
                                    Address = Address,
                                    Phone = phone
                                };

                                stc.Add(st);

                                Added.Rows.Add(newRowAdded); // Thêm vào bảng Added nếu không có giá trị null hoặc chuỗi rỗng
                            }
                        }
                    }
                    else  // certificate
                    {
                        var IDCer = row[1]?.ToString() ?? "";
                        var Name = row[2]?.ToString() ?? "";
                        var SID = row[3]?.ToString() ?? "";
                        var IssueDate = row[4] ?? "";
                        var ExpiryDate = row[5] ?? "";
                        var Grade = row[6]?.ToString() ?? "";

                        // Kiểm tra nếu bất kỳ giá trị nào là null hoặc chuỗi rỗng
                        if (string.IsNullOrEmpty(IDCer) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(SID) || string.IsNullOrEmpty(IssueDate.ToString()) || string.IsNullOrEmpty(ExpiryDate.ToString()) || string.IsNullOrEmpty(Grade))
                        {
                            Reject.Rows.Add(newRowReject); // Thêm vào bảng Reject nếu có giá trị null hoặc chuỗi rỗng
                        }
                        else
                        {
                            if (stc.isExistsCer(IDCer) || !stc.isExistsID(SID))
                            {
                                Reject.Rows.Add(newRowReject);
                            }
                            else
                            {
                                Certification cer = new Certification()
                                {
                                    IDCertificate = IDCer,
                                    Name = Name,
                                    SID = SID,
                                    IssueDate = DateTime.ParseExact(IssueDate.ToString(), "yyyy-MM-dd", null),
                                    ExpiryDate = DateTime.ParseExact(ExpiryDate.ToString(), "yyyy-MM-dd", null),
                                    Grade = Grade,
                                };

                                stc.AddCertificate(cer);

                                Added.Rows.Add(newRowAdded); // Thêm vào bảng Added nếu không có giá trị null hoặc chuỗi rỗng
                            }
                        }
                    }
                }

                BoxMessageImport boxMessage = new BoxMessageImport(Added, Reject);
                frmMain.Instance.RequestReload();
                boxMessage.Show();
                dgvImport.DataSource = null;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error: {err.Message}", "Error At Save", MessageBoxButtons.OK);
            }

        }


    }
}