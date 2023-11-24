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
using System.Windows.Documents;
using System.Windows.Forms;

namespace Essay.Pages.Manager
{
    public partial class frmMStudent : UserControl
    {
        private Action Reload;

        public frmMStudent()
        {
            InitializeComponent();
            Reload = LoadForm;
            frmMain.Instance.ReloadRequested += Reload;
        }

        private void frmMStudent_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        public void LoadForm()
        {
            var studentController = new StudentController();
            List<Student> students = studentController.GetALL();
            DataTable dataTable = new DataTable();

            foreach (Student student in students)
            {

                dgvStudents.Rows.Add(new Object[]
                {
                    student.ID,
                    student.Name,
                    student.Class,
                    student.birthDay,
                    student.Address,
                    student.Phone
                });
                //dataTable.Rows.Add(new Object[]
                //{
                //    student.ID,
                //    student.Name,
                //    student.Class,
                //    student.birthDay,
                //    student.Address,
                //    student.Phone
                //});
            }
            // dgvStudents.DataSource = dataTable; 

        }



    }
}
