namespace Essay.Pages.Dialog
{
    partial class dialogHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogHistory));
            grbFilter = new DevExpress.XtraEditors.GroupControl();
            cbbUser = new ComboBox();
            label3 = new Label();
            cbbType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtFind = new TextBox();
            dgvData = new DataGridView();
            User = new DataGridViewTextBoxColumn();
            NameUser = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grbFilter).BeginInit();
            grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // grbFilter
            // 
            grbFilter.Controls.Add(cbbUser);
            grbFilter.Controls.Add(label3);
            grbFilter.Controls.Add(cbbType);
            grbFilter.Controls.Add(label2);
            grbFilter.Controls.Add(label1);
            grbFilter.Controls.Add(txtFind);
            grbFilter.Location = new Point(2, 2);
            grbFilter.Name = "grbFilter";
            grbFilter.Size = new Size(624, 128);
            grbFilter.TabIndex = 3;
            grbFilter.Text = "Filter";
            // 
            // cbbUser
            // 
            cbbUser.FlatStyle = FlatStyle.Flat;
            cbbUser.FormattingEnabled = true;
            cbbUser.Items.AddRange(new object[] { "All", "Manager", "Employee" });
            cbbUser.Location = new Point(443, 84);
            cbbUser.Name = "cbbUser";
            cbbUser.Size = new Size(136, 21);
            cbbUser.TabIndex = 2;
            cbbUser.SelectionChangeCommitted += cbbUser_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(345, 86);
            label3.Name = "label3";
            label3.Size = new Size(82, 18);
            label3.TabIndex = 1;
            label3.Text = "User Name";
            // 
            // cbbType
            // 
            cbbType.FlatStyle = FlatStyle.Flat;
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "All", "Manager", "Employee" });
            cbbType.Location = new Point(127, 84);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(136, 21);
            cbbType.TabIndex = 2;
            cbbType.SelectionChangeCommitted += cbbType_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 1;
            label2.Text = "Type User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(4, 36);
            label1.Name = "label1";
            label1.Size = new Size(117, 18);
            label1.TabIndex = 1;
            label1.Text = "Search by Name";
            // 
            // txtFind
            // 
            txtFind.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFind.Location = new Point(127, 32);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(452, 28);
            txtFind.TabIndex = 0;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { User, NameUser, Date });
            dgvData.Location = new Point(1, 151);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersVisible = false;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(625, 399);
            dgvData.TabIndex = 2;
            // 
            // User
            // 
            User.HeaderText = "User";
            User.Name = "User";
            User.ReadOnly = true;
            // 
            // NameUser
            // 
            NameUser.HeaderText = "Name";
            NameUser.Name = "NameUser";
            NameUser.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date Login";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // dialogHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 550);
            Controls.Add(grbFilter);
            Controls.Add(dgvData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(643, 589);
            Name = "dialogHistory";
            Text = "History Login";
            Load += dialogHistory_Load;
            ((System.ComponentModel.ISupportInitialize)grbFilter).EndInit();
            grbFilter.ResumeLayout(false);
            grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbFilter;
        private ComboBox cbbType;
        private Label label2;
        private Label label1;
        private TextBox txtFind;
        private DataGridView dgvData;
        private ComboBox cbbUser;
        private Label label3;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn NameUser;
        private DataGridViewTextBoxColumn Date;
    }
}