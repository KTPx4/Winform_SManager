using DevExpress.XtraEditors;
using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Essay.Pages.Dialog
{
    public partial class dialogImport : DevExpress.XtraEditors.XtraForm
    {
        private bool isImportStudent = true;
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
            isImportStudent = isImportStudent;
        }


        private void dialogImport_Load(object sender, EventArgs e)
        {

        }

        private void ReadExcelFile(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                DataTable dt = new DataTable();
                dt.Columns.Add("Line");
                int line = 1;
                // Đọc tiêu đề (dòng đầu tiên) và thêm cột vào DataTable
                for (int i = 1; i <= worksheet.Dimension.Columns; i++)
                {
                    dt.Columns.Add(worksheet.Cells[1, i].Value.ToString());
                }

                // Đọc dữ liệu từ các dòng còn lại và thêm vào DataTable
                for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                {
                    DataRow newRow = dt.NewRow();

                    // Kiểm tra từng ô trước khi thêm vào dòng mới
                    bool hasValue = false;
                    for (int col = 1; col <= worksheet.Dimension.Columns; col++)
                    {
                        object cellValue = worksheet.Cells[row, col].Value;
                        newRow[col] = cellValue;

                        if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                        {
                            hasValue = true;
                        }
                    }

                    // Nếu có ít nhất một ô có giá trị, thì mới thêm vào DataTable
                    if (hasValue)
                    {
                        newRow[0] = line++;
                        dt.Rows.Add(newRow);
                    }
                }

                // Hiển thị dữ liệu trong DataGridView
                dgvImport.DataSource = dt;
            }
        }


        private void ReadCsvFile(string filePath)
        {
            DataTable dt = new DataTable();

            using (TextFieldParser parser = new TextFieldParser(filePath, Encoding.UTF8))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                bool isFirstRow = true;

                dt.Columns.Add("Line");
                int line = 1;
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                 
                    if (fields != null)
                    {
                        // Nếu là dòng đầu tiên, thêm cột vào DataTable
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
                            // Tạo một dòng mới và thêm dữ liệu vào DataTable
                            DataRow newRow = dt.NewRow();

                            // Kiểm tra xem giá trị của từng ô có khác null hay không trước khi thêm vào DataRow
                            bool hasValue = false;
                           
                            for (int i = 0; i < fields.Length; i++)
                            {
                                if (!string.IsNullOrEmpty(fields[i]))
                                {
                                    newRow[i+1] = fields[i];
                                    hasValue = true;
                                }
                            }

                            // Nếu có ít nhất một ô có giá trị, thì mới thêm vào DataTable
                            if (hasValue)
                            {
                                newRow[0] = line++;
                                dt.Rows.Add(newRow);
                            }
                        }
                    }
                }
            }

            // Hiển thị dữ liệu trong DataGridView
            dgvImport.DataSource = dt;
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Open File: " + ex);
            }
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

                    if (System.IO.Path.GetExtension(filePath) == ".xlsx")
                    {
                        if (isImportStudent)
                        {
                            //dgvImport.Columns.Add("SID", "Student ID");
                            //dgvImport.Columns.Add("NameStudent", "Student Name");
                            //dgvImport.Columns.Add("ClassS", "Class");
                            //dgvImport.Columns.Add("birthDay", "Birth Day");
                            //dgvImport.Columns.Add("Address", "Address");
                            //dgvImport.Columns.Add("Phone", "Phone");
                        }

                        ReadExcelFile(filePath);
                    }
                    else if(System.IO.Path.GetExtension(filePath) == ".csv")
                    {
                        ReadCsvFile(filePath);
                    }    
                    else
                    {
                        MessageBox.Show("Chỉ hỗ trợ định dạng tệp tin Excel (.xlsx | .csv)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                    //{

                    //        string line;


                    //        while ((line = reader.ReadLine()) != null)
                    //        {
                    //            string[] parts = line.Split(',');
                    //            dgvImport.Rows.Add(parts);
                    //        }

                    //}
                }
            }


        }
    }
}