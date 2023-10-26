using Component;
using Essay.Components;
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
    public partial class dialogProfile : Form
    {
        public dialogProfile()
        {
            InitializeComponent();
        }
        // pnControl 94, 296 : 3button | 134, 296 : 2button
        private void dialogProfile_Load(object sender, EventArgs e)
        {
            pnTitle = new DraggablePanel(pnTitle, this);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string selectedFilePath = openFileDialog.FileName;
                        string destinationFolder = $"{Variables._pathAvt}"; // Thư mục đích

                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                        string fileExtension = Path.GetExtension(selectedFilePath);
                        string newFileName = fileName + "_id0101" + fileExtension;

                        string destinationFilePath = Path.Combine(destinationFolder, newFileName);

                        File.Copy(selectedFilePath, destinationFilePath, true);

                        using (FileStream fs = new FileStream(destinationFilePath, FileMode.Open, FileAccess.Read))
                        {
                            btnProfile.StateCommon.Back.Image = new Bitmap(Image.FromStream(fs));
                        }


                        // MessageBox.Show("Tệp hình ảnh đã được sao chép vào thư mục 'img' với tên mới: " + newFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }




            //MessageBox.Show("", "", MessageBoxButtons.YesNoCancel);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnGroupTxt.Enabled = true;
        }
    }
}
