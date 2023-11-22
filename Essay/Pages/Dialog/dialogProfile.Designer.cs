namespace Essay.Pages.Dialog
{
    partial class dialogProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dialogProfile));
            btnProfile = new Krypton.Toolkit.KryptonButton();
            grbInfor = new GroupBox();
            pnGroupTxt = new Panel();
            pnStatus = new Panel();
            txtStatus = new TextBox();
            label4 = new Label();
            pnPhone = new Panel();
            txtPhone = new TextBox();
            label7 = new Label();
            pnPass = new Panel();
            ckShowPass = new CheckBox();
            txtPass = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            txtDate = new DevExpress.XtraEditors.DateEdit();
            label3 = new Label();
            pnUser = new Panel();
            txtUser = new TextBox();
            label5 = new Label();
            pnName = new Panel();
            txtName = new TextBox();
            label2 = new Label();
            pnControl = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            pnTitle = new Panel();
            btnEdit = new PictureBox();
            lbTitleForm = new Krypton.Toolkit.KryptonLabel();
            panel1 = new Panel();
            toolTipMessage = new DevExpress.Utils.DefaultToolTipController(components);
            grbInfor.SuspendLayout();
            pnGroupTxt.SuspendLayout();
            pnStatus.SuspendLayout();
            pnPhone.SuspendLayout();
            pnPass.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).BeginInit();
            pnUser.SuspendLayout();
            pnName.SuspendLayout();
            pnControl.SuspendLayout();
            pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProfile
            // 
            toolTipMessage.SetAllowHtmlText(btnProfile, DevExpress.Utils.DefaultBoolean.Default);
            btnProfile.CornerRoundingRadius = 50F;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Location = new Point(198, 3);
            btnProfile.MaximumSize = new Size(60, 60);
            btnProfile.MinimumSize = new Size(60, 60);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(60, 60);
            btnProfile.StateCommon.Back.Color1 = Color.Transparent;
            btnProfile.StateCommon.Back.Color2 = Color.Transparent;
            btnProfile.StateCommon.Back.Image = Properties.Resources.user1;
            btnProfile.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnProfile.StateCommon.Border.Color1 = Color.White;
            btnProfile.StateCommon.Border.Color2 = Color.White;
            btnProfile.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnProfile.StateCommon.Border.Rounding = 50F;
            btnProfile.StateCommon.Border.Width = 2;
            btnProfile.StateTracking.Back.Color1 = Color.FromArgb(192, 0, 192);
            btnProfile.TabIndex = 7;
            toolTipMessage.SetTitle(btnProfile, "Change Picture");
            btnProfile.Values.Text = "";
            btnProfile.Click += btnProfile_Click;
            // 
            // grbInfor
            // 
            toolTipMessage.SetAllowHtmlText(grbInfor, DevExpress.Utils.DefaultBoolean.Default);
            grbInfor.Controls.Add(pnGroupTxt);
            grbInfor.Controls.Add(pnControl);
            grbInfor.Location = new Point(12, 65);
            grbInfor.Name = "grbInfor";
            grbInfor.Size = new Size(469, 343);
            grbInfor.TabIndex = 22;
            grbInfor.TabStop = false;
           // grbInfor.Enter += grbInfor_Enter;
            // 
            // pnGroupTxt
            // 
            toolTipMessage.SetAllowHtmlText(pnGroupTxt, DevExpress.Utils.DefaultBoolean.Default);
            pnGroupTxt.Controls.Add(pnStatus);
            pnGroupTxt.Controls.Add(btnProfile);
            pnGroupTxt.Controls.Add(pnPhone);
            pnGroupTxt.Controls.Add(pnPass);
            pnGroupTxt.Controls.Add(panel4);
            pnGroupTxt.Controls.Add(pnUser);
            pnGroupTxt.Controls.Add(pnName);
            pnGroupTxt.Enabled = false;
            pnGroupTxt.Location = new Point(6, 22);
            pnGroupTxt.Name = "pnGroupTxt";
            pnGroupTxt.Size = new Size(457, 237);
            pnGroupTxt.TabIndex = 22;
            //pnGroupTxt.Paint += pnGroupTxt_Paint;
            // 
            // pnStatus
            // 
            toolTipMessage.SetAllowHtmlText(pnStatus, DevExpress.Utils.DefaultBoolean.Default);
            pnStatus.BackColor = Color.Transparent;
            pnStatus.Controls.Add(txtStatus);
            pnStatus.Controls.Add(label4);
            pnStatus.Location = new Point(250, 172);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(196, 34);
            pnStatus.TabIndex = 22;
            //pnStatus.Paint += pnStatus_Paint;
            // 
            // txtStatus
            // 
            toolTipMessage.SetAllowHtmlText(txtStatus, DevExpress.Utils.DefaultBoolean.Default);
            txtStatus.Location = new Point(43, 5);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(130, 20);
            txtStatus.TabIndex = 6;
            //txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // label4
            // 
            toolTipMessage.SetAllowHtmlText(label4, DevExpress.Utils.DefaultBoolean.Default);
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Status";
           // label4.Click += label4_Click;
            // 
            // pnPhone
            // 
            toolTipMessage.SetAllowHtmlText(pnPhone, DevExpress.Utils.DefaultBoolean.Default);
            pnPhone.BackColor = Color.Transparent;
            pnPhone.Controls.Add(txtPhone);
            pnPhone.Controls.Add(label7);
            pnPhone.Location = new Point(30, 173);
            pnPhone.Name = "pnPhone";
            pnPhone.Size = new Size(207, 34);
            pnPhone.TabIndex = 22;
            //pnPhone.Paint += pnPhone_Paint;
            // 
            // txtPhone
            // 
            toolTipMessage.SetAllowHtmlText(txtPhone, DevExpress.Utils.DefaultBoolean.Default);
            txtPhone.Location = new Point(64, 6);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(126, 20);
            txtPhone.TabIndex = 5;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label7
            // 
            toolTipMessage.SetAllowHtmlText(label7, DevExpress.Utils.DefaultBoolean.Default);
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 1;
            label7.Text = "Phone";
            //label7.Click += label7_Click;
            // 
            // pnPass
            // 
            toolTipMessage.SetAllowHtmlText(pnPass, DevExpress.Utils.DefaultBoolean.Default);
            pnPass.BackColor = Color.Transparent;
            pnPass.Controls.Add(ckShowPass);
            pnPass.Controls.Add(txtPass);
            pnPass.Controls.Add(label6);
            pnPass.Location = new Point(251, 126);
            pnPass.Name = "pnPass";
            pnPass.Size = new Size(196, 34);
            pnPass.TabIndex = 22;
           // pnPass.Paint += pnPass_Paint;
            // 
            // ckShowPass
            // 
            toolTipMessage.SetAllowHtmlText(ckShowPass, DevExpress.Utils.DefaultBoolean.Default);
            ckShowPass.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ckShowPass.AutoSize = true;
            ckShowPass.Location = new Point(176, 10);
            ckShowPass.Name = "ckShowPass";
            ckShowPass.Size = new Size(15, 14);
            ckShowPass.TabIndex = 5;
            ckShowPass.UseVisualStyleBackColor = true;
            ckShowPass.CheckedChanged += ckShowPass_CheckedChanged;
            // 
            // txtPass
            // 
            toolTipMessage.SetAllowHtmlText(txtPass, DevExpress.Utils.DefaultBoolean.Default);
            txtPass.Location = new Point(42, 7);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(130, 20);
            txtPass.TabIndex = 4;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label6
            // 
            toolTipMessage.SetAllowHtmlText(label6, DevExpress.Utils.DefaultBoolean.Default);
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 1;
            label6.Text = "Pass";
           // label6.Click += label6_Click;
            // 
            // panel4
            // 
            toolTipMessage.SetAllowHtmlText(panel4, DevExpress.Utils.DefaultBoolean.Default);
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(txtDate);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(30, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 34);
            panel4.TabIndex = 22;
         //   panel4.Paint += panel4_Paint;
            // 
            // txtDate
            // 
            txtDate.EditValue = null;
            txtDate.Location = new Point(64, 7);
            txtDate.Name = "txtDate";
            txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            txtDate.Size = new Size(126, 20);
            txtDate.TabIndex = 3;
            //txtDate.EditValueChanged += txtDate_EditValueChanged;
            // 
            // label3
            // 
            toolTipMessage.SetAllowHtmlText(label3, DevExpress.Utils.DefaultBoolean.Default);
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Birthday";
            //label3.Click += label3_Click;
            // 
            // pnUser
            // 
            toolTipMessage.SetAllowHtmlText(pnUser, DevExpress.Utils.DefaultBoolean.Default);
            pnUser.BackColor = Color.Transparent;
            pnUser.Controls.Add(txtUser);
            pnUser.Controls.Add(label5);
            pnUser.Location = new Point(251, 80);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(196, 34);
            pnUser.TabIndex = 22;
            //pnUser.Paint += pnUser_Paint;
            // 
            // txtUser
            // 
            toolTipMessage.SetAllowHtmlText(txtUser, DevExpress.Utils.DefaultBoolean.Default);
            txtUser.Location = new Point(42, 6);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(130, 20);
            txtUser.TabIndex = 2;
         //   txtUser.TextChanged += txtUser_TextChanged;
            // 
            // label5
            // 
            toolTipMessage.SetAllowHtmlText(label5, DevExpress.Utils.DefaultBoolean.Default);
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 1;
            label5.Text = "User";
            //label5.Click += label5_Click;
            // 
            // pnName
            // 
            toolTipMessage.SetAllowHtmlText(pnName, DevExpress.Utils.DefaultBoolean.Default);
            pnName.BackColor = Color.Transparent;
            pnName.Controls.Add(txtName);
            pnName.Controls.Add(label2);
            pnName.Location = new Point(30, 80);
            pnName.Name = "pnName";
            pnName.Size = new Size(207, 34);
            pnName.TabIndex = 22;
            pnName.Paint += pnName_Paint;
            // 
            // txtName
            // 
            toolTipMessage.SetAllowHtmlText(txtName, DevExpress.Utils.DefaultBoolean.Default);
            txtName.Location = new Point(64, 7);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(126, 20);
            txtName.TabIndex = 1;
           // txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            toolTipMessage.SetAllowHtmlText(label2, DevExpress.Utils.DefaultBoolean.Default);
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            //label2.Click += label2_Click;
            // 
            // pnControl
            // 
            toolTipMessage.SetAllowHtmlText(pnControl, DevExpress.Utils.DefaultBoolean.Default);
            pnControl.BackColor = Color.Transparent;
            pnControl.Controls.Add(btnCancel);
            pnControl.Controls.Add(btnSave);
            pnControl.Location = new Point(144, 271);
            pnControl.Name = "pnControl";
            pnControl.Size = new Size(308, 52);
            pnControl.TabIndex = 15;
            //pnControl.Paint += pnControl_Paint;
            // 
            // btnCancel
            // 
            toolTipMessage.SetAllowHtmlText(btnCancel, DevExpress.Utils.DefaultBoolean.Default);
            btnCancel.Location = new Point(112, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 46);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += buttonCancel_Click;
            // 
            // btnSave
            // 
            toolTipMessage.SetAllowHtmlText(btnSave, DevExpress.Utils.DefaultBoolean.Default);
            btnSave.Location = new Point(7, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pnTitle
            // 
            toolTipMessage.SetAllowHtmlText(pnTitle, DevExpress.Utils.DefaultBoolean.Default);
            pnTitle.BackColor = Color.Transparent;
            pnTitle.Controls.Add(btnEdit);
            pnTitle.Controls.Add(lbTitleForm);
            pnTitle.Dock = DockStyle.Fill;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(496, 59);
            pnTitle.TabIndex = 22;
           // pnTitle.Paint += pnTitle_Paint;
            // 
            // btnEdit
            // 
            toolTipMessage.SetAllowHtmlText(btnEdit, DevExpress.Utils.DefaultBoolean.Default);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(439, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(42, 43);
            btnEdit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEdit.TabIndex = 12;
            btnEdit.TabStop = false;
            toolTipMessage.SetTitle(btnEdit, "Edit");
            btnEdit.Click += btnEdit_Click;
            // 
            // lbTitleForm
            // 
            toolTipMessage.SetAllowHtmlText(lbTitleForm, DevExpress.Utils.DefaultBoolean.Default);
            lbTitleForm.Location = new Point(202, 11);
            lbTitleForm.Name = "lbTitleForm";
            lbTitleForm.Size = new Size(94, 42);
            lbTitleForm.StateCommon.ShortText.Color1 = Color.Linen;
            lbTitleForm.StateCommon.ShortText.Color2 = Color.LightSkyBlue;
            lbTitleForm.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            lbTitleForm.StateCommon.ShortText.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleForm.TabIndex = 3;
            lbTitleForm.Values.Text = "Profile";
            //lbTitleForm.Click += lbTitleForm_Click;
            // 
            // panel1
            // 
            toolTipMessage.SetAllowHtmlText(panel1, DevExpress.Utils.DefaultBoolean.Default);
            panel1.BackColor = Color.FromArgb(45, 46, 45);
            panel1.Controls.Add(pnTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 59);
            panel1.TabIndex = 4;
          //  panel1.Paint += panel1_Paint;
            // 
            // toolTipMessage
            // 
            // 
            // 
            // 
            toolTipMessage.DefaultController.KeepWhileHovered = true;
            // 
            // dialogProfile
            // 
            toolTipMessage.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(496, 435);
            Controls.Add(grbInfor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "dialogProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dialogProfile";
            Load += dialogProfile_Load;
            grbInfor.ResumeLayout(false);
            pnGroupTxt.ResumeLayout(false);
            pnStatus.ResumeLayout(false);
            pnStatus.PerformLayout();
            pnPhone.ResumeLayout(false);
            pnPhone.PerformLayout();
            pnPass.ResumeLayout(false);
            pnPass.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDate.Properties).EndInit();
            pnUser.ResumeLayout(false);
            pnUser.PerformLayout();
            pnName.ResumeLayout(false);
            pnName.PerformLayout();
            pnControl.ResumeLayout(false);
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnEdit).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnProfile;
        private GroupBox grbInfor;
        private Panel pnControl;
        private Panel pnGroupTxt;
        private Panel pnStatus;
        private Label label4;
        private Panel pnPhone;
        private Label label7;
        private Panel pnPass;
        private Label label6;
        private Panel panel4;
        private Label label3;
        private Panel pnUser;
        private Label label5;
        private Panel pnName;
        private Label label2;
        private TextBox txtStatus;
        private TextBox txtPhone;
        private TextBox txtPass;
        private TextBox txtUser;
        private TextBox txtName;
        private CheckBox ckShowPass;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private Panel pnTitle;
        private PictureBox btnEdit;
        private Krypton.Toolkit.KryptonLabel lbTitleForm;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private DevExpress.Utils.DefaultToolTipController toolTipMessage;
    }
}