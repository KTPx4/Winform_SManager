namespace Essay.Pages.Dialog
{
    partial class dialogImport
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogImport));
            txtUri = new TextBox();
            btnOpen = new PictureBox();
            dgvImport = new DataGridView();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnDel = new DevExpress.XtraEditors.SimpleButton();
            alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(components);
            ((System.ComponentModel.ISupportInitialize)btnOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImport).BeginInit();
            SuspendLayout();
            // 
            // txtUri
            // 
            txtUri.BackColor = Color.LightGray;
            txtUri.Enabled = false;
            txtUri.Location = new Point(70, 27);
            txtUri.Name = "txtUri";
            txtUri.Size = new Size(475, 21);
            txtUri.TabIndex = 0;
            // 
            // btnOpen
            // 
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.Location = new Point(551, 27);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(26, 21);
            btnOpen.SizeMode = PictureBoxSizeMode.Zoom;
            btnOpen.TabIndex = 1;
            btnOpen.TabStop = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // dgvImport
            // 
            dgvImport.AllowUserToAddRows = false;
            dgvImport.AllowUserToDeleteRows = false;
            dgvImport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImport.BackgroundColor = Color.FromArgb(230, 240, 250);
            dgvImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImport.Dock = DockStyle.Bottom;
            dgvImport.Location = new Point(0, 130);
            dgvImport.Name = "dgvImport";
            dgvImport.RowHeadersVisible = false;
            dgvImport.RowTemplate.Height = 25;
            dgvImport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImport.Size = new Size(646, 388);
            dgvImport.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Appearance.BackColor = Color.LightBlue;
            btnSave.Appearance.Options.UseBackColor = true;
            btnSave.Location = new Point(223, 75);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 35);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.Appearance.BackColor = Color.Tomato;
            btnDel.Appearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnDel.Appearance.ForeColor = Color.Black;
            btnDel.Appearance.Options.UseBackColor = true;
            btnDel.Appearance.Options.UseBorderColor = true;
            btnDel.Appearance.Options.UseForeColor = true;
            btnDel.Location = new Point(350, 75);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(89, 35);
            btnDel.TabIndex = 3;
            btnDel.Text = "Delete Row";
            btnDel.Click += btnDel_Click;
            // 
            // dialogImport
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 518);
            Controls.Add(btnDel);
            Controls.Add(btnSave);
            Controls.Add(dgvImport);
            Controls.Add(btnOpen);
            Controls.Add(txtUri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IconOptions.Image = (Image)resources.GetObject("dialogImport.IconOptions.Image");
            Name = "dialogImport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import Data";
            Load += dialogImport_Load;
            ((System.ComponentModel.ISupportInitialize)btnOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvImport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUri;
        private PictureBox btnOpen;
        private DataGridView dgvImport;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}