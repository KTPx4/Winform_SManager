using DevExpress.XtraSpreadsheet.Model;
using Essay.Components;
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
        public Action Reload;

        public dialogHistory()
        {
            InitializeComponent();
            this.UserName = "";
            isAll = true;
            Reload = ReloadForm;
            frmMain.Instance.ReloadRequested += Reload;

        }
        public dialogHistory(String username, bool isManager)
        {
            InitializeComponent();
            this.UserName = username;
            isAll = false;
            this.isManager = isManager;
            Reload = ReloadForm;
            frmMain.Instance.ReloadRequested += Reload;
        }

        private void dialogHistory_Load(object sender, EventArgs e)
        {

            LoadHis();
        }

        private void ReloadForm()
        {
            LoadHis();
        }
        // Show to DataGridView
        private void ShowDGV(List<List<String>> ListData)
        {
            foreach (List<String> hitem in ListData)
            {
                DataGridViewRow row = (DataGridViewRow)dgvData.RowTemplate.Clone();
                row.CreateCells(dgvData, hitem[0], hitem[1], hitem[2], hitem[3]);
                dgvData.Rows.Add(row);
                if (hitem[1].Contains("Manager"))
                {
                    row.DefaultCellStyle.BackColor = Variables._Back_Items_Manager;
                }
            }
        }
        
        
        private void LoadHis()
        {
            try
            {
                HistoryController history = new HistoryController();
                List<List<String>> DataHis;
                dgvData.Rows.Clear();

                if (isAll)
                {
                    DataHis = history.getAllHis();
                }
                else
                {
                    grbFilter.Enabled = false;
                    cbbType.Text = isManager ? "Manager" : "Employee";
                    cbbUser.Text = UserName;
                    DataHis = history.getHisUser(UserName);
                }

                ShowDGV(DataHis);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error When Show Data: " + ex.Message);
            }
        }
        

        //Search From Text Box
        private void ShowSearch(String search)
        {
            if (search == "")
            {
                LoadHis();
            }
            else
            {
                dgvData.Rows.Clear();
                HistoryController historyController = new HistoryController();
                List<List<String>> DataHis = historyController.SearchHistory(search);
                ShowDGV(DataHis);
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
            TimeTyping.Stop();
            TimeTyping.Start();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            frmMain.Instance.RequestReload();

        }
     
        private void TimeTyping_Tick(object sender, EventArgs e)
        {
            TimeTyping.Stop();
            string search = txtFind.Text;
            ShowSearch(search);
        }
    }
}
