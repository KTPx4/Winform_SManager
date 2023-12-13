namespace Essay.Pages.Dialog
{
    partial class dialogCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogCertificate));
            grbInfor = new GroupBox();
            label6 = new Label();
            txtExpiryDate = new DevExpress.XtraEditors.DateEdit();
            txtIssueDate = new DevExpress.XtraEditors.DateEdit();
            txtGrade = new DevExpress.XtraEditors.TextEdit();
            label5 = new Label();
            label3 = new Label();
            txtID = new DevExpress.XtraEditors.TextEdit();
            label4 = new Label();
            label1 = new Label();
            txtName = new DevExpress.XtraEditors.TextEdit();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            grbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtExpiryDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExpiryDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIssueDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIssueDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGrade.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            SuspendLayout();
            // 
            // grbInfor
            // 
            grbInfor.BackColor = Color.LightGray;
            grbInfor.Controls.Add(label6);
            grbInfor.Controls.Add(txtExpiryDate);
            grbInfor.Controls.Add(txtIssueDate);
            grbInfor.Controls.Add(txtGrade);
            grbInfor.Controls.Add(label5);
            grbInfor.Controls.Add(label3);
            grbInfor.Controls.Add(txtID);
            grbInfor.Controls.Add(label4);
            grbInfor.Controls.Add(label1);
            grbInfor.Controls.Add(txtName);
            grbInfor.Location = new Point(40, 31);
            grbInfor.Name = "grbInfor";
            grbInfor.Size = new Size(260, 239);
            grbInfor.TabIndex = 7;
            grbInfor.TabStop = false;
            grbInfor.Text = "Infor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 197);
            label6.Name = "label6";
            label6.Size = new Size(81, 13);
            label6.TabIndex = 7;
            label6.Text = "Grade / OverAll";
            // 
            // txtExpiryDate
            // 
            txtExpiryDate.EditValue = null;
            txtExpiryDate.Location = new Point(114, 156);
            txtExpiryDate.Name = "txtExpiryDate";
            txtExpiryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtExpiryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtExpiryDate.Size = new Size(116, 20);
            txtExpiryDate.TabIndex = 12;
            // 
            // txtIssueDate
            // 
            txtIssueDate.EditValue = null;
            txtIssueDate.Location = new Point(114, 115);
            txtIssueDate.Name = "txtIssueDate";
            txtIssueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtIssueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtIssueDate.Size = new Size(116, 20);
            txtIssueDate.TabIndex = 12;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(114, 193);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(116, 20);
            txtGrade.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 159);
            label5.Name = "label5";
            label5.Size = new Size(63, 13);
            label5.TabIndex = 7;
            label5.Text = "Expiry Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 81);
            label3.Name = "label3";
            label3.Size = new Size(34, 13);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(114, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(116, 20);
            txtID.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 119);
            label4.Name = "label4";
            label4.Size = new Size(59, 13);
            label4.TabIndex = 8;
            label4.Text = "Issue Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 13);
            label1.TabIndex = 11;
            label1.Text = "ID Certificate";
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(116, 20);
            txtName.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(182, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(75, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 40);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // dialogCertificate
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 364);
            Controls.Add(grbInfor);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IconOptions.Image = (Image)resources.GetObject("dialogCertificate.IconOptions.Image");
            Name = "dialogCertificate";
            Text = "Certificate";
            Load += dialogCertificate_Load;
            grbInfor.ResumeLayout(false);
            grbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtExpiryDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExpiryDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIssueDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIssueDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGrade.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInfor;
        private Label label6;
        private DevExpress.XtraEditors.DateEdit txtIssueDate;
        private DevExpress.XtraEditors.TextEdit txtGrade;
        private Label label5;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtID;
        private Label label4;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DateEdit txtExpiryDate;
    }
}