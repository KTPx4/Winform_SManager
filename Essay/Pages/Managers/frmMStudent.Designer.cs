namespace Essay.Pages.Manager
{
    partial class frmMStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            SID = new DataGridViewTextBoxColumn();
            SName = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            BirthDay = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            grbListStudents = new DevExpress.XtraEditors.GroupControl();
            dgvCertificate = new DataGridView();
            pnRight = new Panel();
            grbListCertificate = new DevExpress.XtraEditors.GroupControl();
            grbControls = new DevExpress.XtraEditors.GroupControl();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            label2 = new Label();
            label1 = new Label();
            btnImportS = new Button();
            btnImportC = new Button();
            btnExportS = new Button();
            btnExportC = new Button();
            btnEditCert = new Button();
            btnDelCer = new Button();
            btnAddCert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ID = new DataGridViewTextBoxColumn();
            NameCer = new DataGridViewTextBoxColumn();
            SIDCer = new DataGridViewTextBoxColumn();
            IssueDate = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            ExpiryDate = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            Grade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grbListStudents).BeginInit();
            grbListStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCertificate).BeginInit();
            pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grbListCertificate).BeginInit();
            grbListCertificate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grbControls).BeginInit();
            grbControls.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { SID, SName, Class, BirthDay, Address, Phone });
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.GridColor = Color.Black;
            dgvStudents.Location = new Point(2, 23);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.Size = new Size(606, 253);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellEnter += dgvStudents_CellEnter;
            dgvStudents.KeyDown += dgvStudents_KeyDown;
            // 
            // SID
            // 
            SID.HeaderText = "SID";
            SID.Name = "SID";
            SID.ReadOnly = true;
            // 
            // SName
            // 
            SName.HeaderText = "Name";
            SName.Name = "SName";
            SName.ReadOnly = true;
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            Class.ReadOnly = true;
            // 
            // BirthDay
            // 
            BirthDay.Checked = false;
            BirthDay.Format = DateTimePickerFormat.Short;
            BirthDay.HeaderText = "Birth Day";
            BirthDay.Name = "BirthDay";
            BirthDay.ReadOnly = true;
            BirthDay.Resizable = DataGridViewTriState.True;
            BirthDay.SortMode = DataGridViewColumnSortMode.Programmatic;
            BirthDay.Width = 100;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // grbListStudents
            // 
            grbListStudents.Appearance.BackColor = Color.Transparent;
            grbListStudents.Appearance.Options.UseBackColor = true;
            grbListStudents.Controls.Add(dgvStudents);
            grbListStudents.Dock = DockStyle.Top;
            grbListStudents.Location = new Point(0, 0);
            grbListStudents.Name = "grbListStudents";
            grbListStudents.Size = new Size(610, 278);
            grbListStudents.TabIndex = 5;
            grbListStudents.Text = "List Students";
            // 
            // dgvCertificate
            // 
            dgvCertificate.AllowUserToAddRows = false;
            dgvCertificate.AllowUserToDeleteRows = false;
            dgvCertificate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCertificate.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvCertificate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertificate.Columns.AddRange(new DataGridViewColumn[] { ID, NameCer, SIDCer, IssueDate, ExpiryDate, Grade });
            dgvCertificate.Dock = DockStyle.Fill;
            dgvCertificate.GridColor = Color.Black;
            dgvCertificate.Location = new Point(2, 23);
            dgvCertificate.Name = "dgvCertificate";
            dgvCertificate.RowHeadersVisible = false;
            dgvCertificate.RowTemplate.Height = 25;
            dgvCertificate.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCertificate.Size = new Size(606, 206);
            dgvCertificate.TabIndex = 0;
            dgvCertificate.KeyDown += dgvCertificate_KeyDown;
            // 
            // pnRight
            // 
            pnRight.Controls.Add(grbListCertificate);
            pnRight.Controls.Add(grbListStudents);
            pnRight.Dock = DockStyle.Fill;
            pnRight.Location = new Point(151, 0);
            pnRight.Name = "pnRight";
            pnRight.Size = new Size(610, 509);
            pnRight.TabIndex = 7;
            // 
            // grbListCertificate
            // 
            grbListCertificate.Appearance.BackColor = Color.Transparent;
            grbListCertificate.Appearance.Options.UseBackColor = true;
            grbListCertificate.Controls.Add(dgvCertificate);
            grbListCertificate.Dock = DockStyle.Fill;
            grbListCertificate.Location = new Point(0, 278);
            grbListCertificate.Name = "grbListCertificate";
            grbListCertificate.Size = new Size(610, 231);
            grbListCertificate.TabIndex = 4;
            grbListCertificate.Text = "List Certificate";
            // 
            // grbControls
            // 
            grbControls.Appearance.BackColor = Color.Transparent;
            grbControls.Appearance.Options.UseBackColor = true;
            grbControls.Controls.Add(kryptonBorderEdge1);
            grbControls.Controls.Add(label2);
            grbControls.Controls.Add(label1);
            grbControls.Controls.Add(btnImportS);
            grbControls.Controls.Add(btnImportC);
            grbControls.Controls.Add(btnExportS);
            grbControls.Controls.Add(btnExportC);
            grbControls.Controls.Add(btnEditCert);
            grbControls.Controls.Add(btnDelCer);
            grbControls.Controls.Add(btnAddCert);
            grbControls.Controls.Add(btnDelete);
            grbControls.Controls.Add(btnEdit);
            grbControls.Controls.Add(btnAdd);
            grbControls.Dock = DockStyle.Left;
            grbControls.Location = new Point(0, 0);
            grbControls.Name = "grbControls";
            grbControls.Size = new Size(151, 509);
            grbControls.TabIndex = 6;
            grbControls.Text = "Controls";
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(5, 277);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(142, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 33);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 1;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 286);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 1;
            label1.Text = "Certificate";
            // 
            // btnImportS
            // 
            btnImportS.Location = new Point(19, 181);
            btnImportS.Name = "btnImportS";
            btnImportS.Size = new Size(102, 36);
            btnImportS.TabIndex = 0;
            btnImportS.Text = "Import";
            btnImportS.UseVisualStyleBackColor = true;
            btnImportS.Click += btnImportS_Click;
            // 
            // btnImportC
            // 
            btnImportC.Location = new Point(19, 432);
            btnImportC.Name = "btnImportC";
            btnImportC.Size = new Size(102, 36);
            btnImportC.TabIndex = 0;
            btnImportC.Text = "Import";
            btnImportC.UseVisualStyleBackColor = true;
            btnImportC.Click += btnImportC_Click;
            // 
            // btnExportS
            // 
            btnExportS.Location = new Point(19, 223);
            btnExportS.Name = "btnExportS";
            btnExportS.Size = new Size(102, 36);
            btnExportS.TabIndex = 0;
            btnExportS.Text = "Export";
            btnExportS.UseVisualStyleBackColor = true;
            btnExportS.Click += btnExportS_Click;
            // 
            // btnExportC
            // 
            btnExportC.Location = new Point(19, 472);
            btnExportC.Name = "btnExportC";
            btnExportC.Size = new Size(102, 36);
            btnExportC.TabIndex = 0;
            btnExportC.Text = "Export";
            btnExportC.UseVisualStyleBackColor = true;
            btnExportC.Click += btnExportC_Click;
            // 
            // btnEditCert
            // 
            btnEditCert.Location = new Point(19, 349);
            btnEditCert.Name = "btnEditCert";
            btnEditCert.Size = new Size(102, 36);
            btnEditCert.TabIndex = 0;
            btnEditCert.Text = "Edit Certìicate";
            btnEditCert.UseVisualStyleBackColor = true;
            btnEditCert.Click += btnEditCert_Click;
            // 
            // btnDelCer
            // 
            btnDelCer.Location = new Point(19, 391);
            btnDelCer.Name = "btnDelCer";
            btnDelCer.Size = new Size(102, 36);
            btnDelCer.TabIndex = 0;
            btnDelCer.Text = "Delete Certificate";
            btnDelCer.UseVisualStyleBackColor = true;
            btnDelCer.Click += btnDelCer_Click;
            // 
            // btnAddCert
            // 
            btnAddCert.Location = new Point(19, 306);
            btnAddCert.Name = "btnAddCert";
            btnAddCert.Size = new Size(102, 36);
            btnAddCert.TabIndex = 0;
            btnAddCert.Text = "Add Certificate";
            btnAddCert.UseVisualStyleBackColor = true;
            btnAddCert.Click += btnAddCert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(19, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(19, 95);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 36);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID Certificate";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NameCer
            // 
            NameCer.HeaderText = "Name Certificate";
            NameCer.Name = "NameCer";
            NameCer.ReadOnly = true;
            // 
            // SIDCer
            // 
            SIDCer.HeaderText = "Student ID";
            SIDCer.Name = "SIDCer";
            SIDCer.ReadOnly = true;
            SIDCer.Visible = false;
            // 
            // IssueDate
            // 
            IssueDate.Checked = false;
            IssueDate.Format = DateTimePickerFormat.Short;
            IssueDate.HeaderText = "Issue Date";
            IssueDate.Name = "IssueDate";
            IssueDate.ReadOnly = true;
            IssueDate.Resizable = DataGridViewTriState.True;
            IssueDate.SortMode = DataGridViewColumnSortMode.Automatic;
            IssueDate.Width = 121;
            // 
            // ExpiryDate
            // 
            ExpiryDate.Checked = false;
            ExpiryDate.Format = DateTimePickerFormat.Short;
            ExpiryDate.HeaderText = "Expiry Date";
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.ReadOnly = true;
            ExpiryDate.Resizable = DataGridViewTriState.True;
            ExpiryDate.SortMode = DataGridViewColumnSortMode.Automatic;
            ExpiryDate.Width = 120;
            // 
            // Grade
            // 
            Grade.HeaderText = "Grade / OverAll";
            Grade.Name = "Grade";
            Grade.ReadOnly = true;
            // 
            // frmMStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnRight);
            Controls.Add(grbControls);
            Name = "frmMStudent";
            Size = new Size(761, 509);
            Load += frmMStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)grbListStudents).EndInit();
            grbListStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCertificate).EndInit();
            pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grbListCertificate).EndInit();
            grbListCertificate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grbControls).EndInit();
            grbControls.ResumeLayout(false);
            grbControls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvStudents;
        private DevExpress.XtraEditors.GroupControl grbListStudents;
        private DataGridView dgvCertificate;
        private Panel pnRight;
        private DevExpress.XtraEditors.GroupControl grbListCertificate;
        private DevExpress.XtraEditors.GroupControl grbControls;
        private Button btnImportS;
        private Button btnImportC;
        private Button btnExportS;
        private Button btnExportC;
        private Button btnEditCert;
        private Button btnAddCert;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label2;
        private Label label1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private DataGridViewTextBoxColumn SID;
        private DataGridViewTextBoxColumn SName;
        private DataGridViewTextBoxColumn Class;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn BirthDay;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private Button btnDelCer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameCer;
        private DataGridViewTextBoxColumn SIDCer;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn IssueDate;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn ExpiryDate;
        private DataGridViewTextBoxColumn Grade;
    }
}
