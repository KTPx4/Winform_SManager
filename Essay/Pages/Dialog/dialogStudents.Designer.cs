namespace Essay.Pages.Dialog
{
    partial class dialogStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogStudents));
            grbInfor = new GroupBox();
            txtBirth = new DevExpress.XtraEditors.DateEdit();
            label5 = new Label();
            label4 = new Label();
            txtAddress = new DevExpress.XtraEditors.TextEdit();
            label3 = new Label();
            txtID = new DevExpress.XtraEditors.TextEdit();
            label2 = new Label();
            txtClass = new DevExpress.XtraEditors.TextEdit();
            label1 = new Label();
            txtName = new DevExpress.XtraEditors.TextEdit();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            grbInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtClass.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            SuspendLayout();
            // 
            // grbInfor
            // 
            grbInfor.BackColor = Color.LightGray;
            grbInfor.Controls.Add(txtBirth);
            grbInfor.Controls.Add(label5);
            grbInfor.Controls.Add(label4);
            grbInfor.Controls.Add(txtAddress);
            grbInfor.Controls.Add(label3);
            grbInfor.Controls.Add(txtID);
            grbInfor.Controls.Add(label2);
            grbInfor.Controls.Add(txtClass);
            grbInfor.Controls.Add(label1);
            grbInfor.Controls.Add(txtName);
            grbInfor.Location = new Point(33, 22);
            grbInfor.Name = "grbInfor";
            grbInfor.Size = new Size(269, 239);
            grbInfor.TabIndex = 4;
            grbInfor.TabStop = false;
            grbInfor.Text = "Infor";
            // 
            // txtBirth
            // 
            txtBirth.EditValue = null;
            txtBirth.Location = new Point(110, 140);
            txtBirth.Name = "txtBirth";
            txtBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtBirth.Size = new Size(116, 20);
            txtBirth.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 185);
            label5.Name = "label5";
            label5.Size = new Size(46, 13);
            label5.TabIndex = 7;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 145);
            label4.Name = "label4";
            label4.Size = new Size(51, 13);
            label4.TabIndex = 8;
            label4.Text = "Birth Day";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(110, 178);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(116, 20);
            txtAddress.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 68);
            label3.Name = "label3";
            label3.Size = new Size(34, 13);
            label3.TabIndex = 9;
            label3.Text = "Name";
            // 
            // txtID
            // 
            txtID.Location = new Point(110, 23);
            txtID.Name = "txtID";
            txtID.Size = new Size(116, 20);
            txtID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 106);
            label2.Name = "label2";
            label2.Size = new Size(32, 13);
            label2.TabIndex = 10;
            label2.Text = "Class";
            // 
            // txtClass
            // 
            txtClass.Location = new Point(110, 99);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(116, 20);
            txtClass.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 26);
            label1.Name = "label1";
            label1.Size = new Size(18, 13);
            label1.TabIndex = 11;
            label1.Text = "ID";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(116, 20);
            txtName.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(180, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(79, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(73, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            // 
            // dialogStudents
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 344);
            Controls.Add(grbInfor);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            IconOptions.Image = (Image)resources.GetObject("dialogStudents.IconOptions.Image");
            Name = "dialogStudents";
            Text = "Student";
            Load += dialogStudents_Load;
            grbInfor.ResumeLayout(false);
            grbInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBirth.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtID.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtClass.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInfor;
        private DevExpress.XtraEditors.DateEdit txtBirth;
        private Label label5;
        private Label label4;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private Label label3;
        private DevExpress.XtraEditors.TextEdit txtID;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private Label label1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}