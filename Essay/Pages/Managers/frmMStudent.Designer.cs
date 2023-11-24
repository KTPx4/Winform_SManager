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
            grbListStudents = new DevExpress.XtraEditors.GroupControl();
            dgvCertificate = new DataGridView();
            pnRight = new Panel();
            grbListCertificate = new DevExpress.XtraEditors.GroupControl();
            grbControls = new DevExpress.XtraEditors.GroupControl();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            btnImportS = new Button();
            button1 = new Button();
            btnExportS = new Button();
            btnEditCert = new Button();
            btnAddCert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            SID = new DataGridViewTextBoxColumn();
            SName = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            BirthDay = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
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
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { SID, SName, Class, BirthDay, Address, Phone });
            dgvStudents.Dock = DockStyle.Fill;
            dgvStudents.GridColor = Color.Black;
            dgvStudents.Location = new Point(2, 23);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.RowTemplate.Height = 25;
            dgvStudents.Size = new Size(606, 265);
            dgvStudents.TabIndex = 0;
            // 
            // grbListStudents
            // 
            grbListStudents.Appearance.BackColor = Color.Transparent;
            grbListStudents.Appearance.Options.UseBackColor = true;
            grbListStudents.Controls.Add(dgvStudents);
            grbListStudents.Dock = DockStyle.Top;
            grbListStudents.Location = new Point(0, 0);
            grbListStudents.Name = "grbListStudents";
            grbListStudents.Size = new Size(610, 290);
            grbListStudents.TabIndex = 5;
            grbListStudents.Text = "List Students";
            // 
            // dgvCertificate
            // 
            dgvCertificate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCertificate.BackgroundColor = Color.FromArgb(45, 45, 45);
            dgvCertificate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCertificate.Dock = DockStyle.Fill;
            dgvCertificate.GridColor = Color.White;
            dgvCertificate.Location = new Point(2, 23);
            dgvCertificate.Name = "dgvCertificate";
            dgvCertificate.RowTemplate.Height = 25;
            dgvCertificate.Size = new Size(606, 194);
            dgvCertificate.TabIndex = 0;
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
            grbListCertificate.Location = new Point(0, 290);
            grbListCertificate.Name = "grbListCertificate";
            grbListCertificate.Size = new Size(610, 219);
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
            grbControls.Controls.Add(button2);
            grbControls.Controls.Add(btnImportS);
            grbControls.Controls.Add(button1);
            grbControls.Controls.Add(btnExportS);
            grbControls.Controls.Add(btnEditCert);
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
            kryptonBorderEdge1.Location = new Point(5, 289);
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
            label1.Location = new Point(5, 298);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 1;
            label1.Text = "Certificate";
            // 
            // button2
            // 
            button2.Location = new Point(19, 188);
            button2.Name = "button2";
            button2.Size = new Size(102, 36);
            button2.TabIndex = 0;
            button2.Text = "Import";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnImportS
            // 
            btnImportS.Location = new Point(19, 420);
            btnImportS.Name = "btnImportS";
            btnImportS.Size = new Size(102, 36);
            btnImportS.TabIndex = 0;
            btnImportS.Text = "Import";
            btnImportS.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 230);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 0;
            button1.Text = "Export";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExportS
            // 
            btnExportS.Location = new Point(19, 462);
            btnExportS.Name = "btnExportS";
            btnExportS.Size = new Size(102, 36);
            btnExportS.TabIndex = 0;
            btnExportS.Text = "Export";
            btnExportS.UseVisualStyleBackColor = true;
            // 
            // btnEditCert
            // 
            btnEditCert.Location = new Point(19, 378);
            btnEditCert.Name = "btnEditCert";
            btnEditCert.Size = new Size(102, 36);
            btnEditCert.TabIndex = 0;
            btnEditCert.Text = "Edit Certìicate";
            btnEditCert.UseVisualStyleBackColor = true;
            // 
            // btnAddCert
            // 
            btnAddCert.Location = new Point(19, 336);
            btnAddCert.Name = "btnAddCert";
            btnAddCert.Size = new Size(102, 36);
            btnAddCert.TabIndex = 0;
            btnAddCert.Text = "Add Certificate";
            btnAddCert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(19, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(19, 102);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 36);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 60);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // SID
            // 
            SID.HeaderText = "SID";
            SID.Name = "SID";
            // 
            // SName
            // 
            SName.HeaderText = "Name";
            SName.Name = "SName";
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
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
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
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
        private Button button2;
        private Button btnImportS;
        private Button button1;
        private Button btnExportS;
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
    }
}
