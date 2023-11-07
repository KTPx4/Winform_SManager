using Essay.Controllers;
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
    public partial class dialogHistory : Form
    {
        public String UserName { get; set; }

        private bool isAll = false;
        private bool isManager = false;

        public dialogHistory()
        {
            InitializeComponent();
            this.UserName = "";
            isAll = true;

        }
        public dialogHistory(String username, bool isManager)
        {
            InitializeComponent();
            this.UserName = username;
            isAll = false;
            this.isManager = isManager;
        }

        private void dialogHistory_Load(object sender, EventArgs e)
        {
            if (isAll)
            {
               
            }
            else
            {
                grbFilter.Enabled = false;
                cbbType.Text = isManager ? "Manager" : "Employee";
                cbbUser.Text = UserName;



                History history = new History();
                List<List<String>> h = history.getHisEmp(UserName);
                foreach(List<String> hitem in h)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvData.RowTemplate.Clone();
                    row.CreateCells(dgvData, hitem[0], hitem[1], hitem[2]);
                    dgvData.Rows.Add(row);
                }
            }
        }

        private void cbbType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbUser.Text = "";
        }

        private void cbbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbbType.Text = "";
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            cbbType.Text = "";
            cbbUser.Text = "";
        }
    }
}
