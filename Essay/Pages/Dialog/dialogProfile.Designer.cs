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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            pnTitle = new Panel();
            btnEdit = new PictureBox();
            lbTitleForm = new Krypton.Toolkit.KryptonLabel();
            pnRightTitle = new Panel();
            pnMini = new Panel();
            ptbMini = new PictureBox();
            pnClose = new Panel();
            ptbClose = new PictureBox();
            panel1 = new Panel();
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
            pnRightTitle.SuspendLayout();
            pnMini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            pnClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProfile
            // 
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
            btnProfile.Values.Text = "";
            btnProfile.Click += btnProfile_Click;
            // 
            // grbInfor
            // 
            grbInfor.Controls.Add(pnGroupTxt);
            grbInfor.Controls.Add(pnControl);
            grbInfor.Location = new Point(12, 65);
            grbInfor.Name = "grbInfor";
            grbInfor.Size = new Size(469, 356);
            grbInfor.TabIndex = 22;
            grbInfor.TabStop = false;
            // 
            // pnGroupTxt
            // 
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
            pnGroupTxt.Size = new Size(457, 268);
            pnGroupTxt.TabIndex = 22;
            // 
            // pnStatus
            // 
            pnStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnStatus.BackColor = Color.Transparent;
            pnStatus.Controls.Add(txtStatus);
            pnStatus.Controls.Add(label4);
            pnStatus.Location = new Point(250, 185);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(196, 34);
            pnStatus.TabIndex = 22;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(43, 5);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(130, 20);
            txtStatus.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Status";
            // 
            // pnPhone
            // 
            pnPhone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnPhone.BackColor = Color.Transparent;
            pnPhone.Controls.Add(txtPhone);
            pnPhone.Controls.Add(label7);
            pnPhone.Location = new Point(30, 186);
            pnPhone.Name = "pnPhone";
            pnPhone.Size = new Size(207, 34);
            pnPhone.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(64, 6);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(126, 20);
            txtPhone.TabIndex = 5;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 10);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 1;
            label7.Text = "Phone";
            // 
            // pnPass
            // 
            pnPass.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnPass.BackColor = Color.Transparent;
            pnPass.Controls.Add(ckShowPass);
            pnPass.Controls.Add(txtPass);
            pnPass.Controls.Add(label6);
            pnPass.Location = new Point(251, 139);
            pnPass.Name = "pnPass";
            pnPass.Size = new Size(196, 34);
            pnPass.TabIndex = 22;
            // 
            // ckShowPass
            // 
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
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 10);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 1;
            label6.Text = "Pass";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(txtDate);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(30, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(207, 34);
            panel4.TabIndex = 22;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Birthday";
            // 
            // pnUser
            // 
            pnUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnUser.BackColor = Color.Transparent;
            pnUser.Controls.Add(txtUser);
            pnUser.Controls.Add(label5);
            pnUser.Location = new Point(251, 93);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(196, 34);
            pnUser.TabIndex = 22;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(42, 6);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(130, 20);
            txtUser.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 10);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 1;
            label5.Text = "User";
            // 
            // pnName
            // 
            pnName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnName.BackColor = Color.Transparent;
            pnName.Controls.Add(txtName);
            pnName.Controls.Add(label2);
            pnName.Location = new Point(30, 93);
            pnName.Name = "pnName";
            pnName.Size = new Size(207, 34);
            pnName.TabIndex = 22;
            pnName.Paint += pnName_Paint;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 7);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(126, 20);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // pnControl
            // 
            pnControl.BackColor = Color.Transparent;
            pnControl.Controls.Add(simpleButton1);
            pnControl.Location = new Point(144, 296);
            pnControl.Name = "pnControl";
            pnControl.Size = new Size(308, 52);
            pnControl.TabIndex = 15;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.BackColor = Color.LightCyan;
            simpleButton1.Appearance.ForeColor = Color.Black;
            simpleButton1.Appearance.Options.UseBackColor = true;
            simpleButton1.Appearance.Options.UseForeColor = true;
            simpleButton1.AppearanceHovered.BackColor = Color.DeepSkyBlue;
            simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            simpleButton1.AppearancePressed.BackColor = Color.SteelBlue;
            simpleButton1.AppearancePressed.Options.UseBackColor = true;
            simpleButton1.Location = new Point(19, 7);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(80, 42);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "simpleButton1";
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.Transparent;
            pnTitle.Controls.Add(btnEdit);
            pnTitle.Controls.Add(lbTitleForm);
            pnTitle.Dock = DockStyle.Fill;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(496, 59);
            pnTitle.TabIndex = 22;
            // 
            // btnEdit
            // 
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(439, 8);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(42, 43);
            btnEdit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEdit.TabIndex = 12;
            btnEdit.TabStop = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lbTitleForm
            // 
            lbTitleForm.Location = new Point(202, 11);
            lbTitleForm.Name = "lbTitleForm";
            lbTitleForm.Size = new Size(94, 42);
            lbTitleForm.StateCommon.ShortText.Color1 = Color.Linen;
            lbTitleForm.StateCommon.ShortText.Color2 = Color.LightSkyBlue;
            lbTitleForm.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            lbTitleForm.StateCommon.ShortText.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleForm.TabIndex = 3;
            lbTitleForm.Values.Text = "Profile";
            // 
            // pnRightTitle
            // 
            pnRightTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnRightTitle.BackColor = Color.Transparent;
            pnRightTitle.Controls.Add(pnMini);
            pnRightTitle.Controls.Add(pnClose);
            pnRightTitle.Location = new Point(954, 1);
            pnRightTitle.Name = "pnRightTitle";
            pnRightTitle.Size = new Size(153, 56);
            pnRightTitle.TabIndex = 0;
            // 
            // pnMini
            // 
            pnMini.BackColor = Color.Transparent;
            pnMini.Controls.Add(ptbMini);
            pnMini.Location = new Point(77, 0);
            pnMini.Name = "pnMini";
            pnMini.Size = new Size(36, 53);
            pnMini.TabIndex = 5;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = Color.Transparent;
            ptbMini.BackgroundImage = Properties.Resources.icons8_minus_material_filled_32;
            ptbMini.BackgroundImageLayout = ImageLayout.Stretch;
            ptbMini.Cursor = Cursors.Hand;
            ptbMini.Location = new Point(8, 17);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(20, 24);
            ptbMini.TabIndex = 1;
            ptbMini.TabStop = false;
            // 
            // pnClose
            // 
            pnClose.BackColor = Color.Transparent;
            pnClose.Controls.Add(ptbClose);
            pnClose.Location = new Point(113, 0);
            pnClose.Name = "pnClose";
            pnClose.Size = new Size(36, 53);
            pnClose.TabIndex = 4;
            // 
            // ptbClose
            // 
            ptbClose.BackColor = Color.Transparent;
            ptbClose.BackgroundImage = Properties.Resources.icons8_close_ios_16_filled_321;
            ptbClose.BackgroundImageLayout = ImageLayout.Zoom;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.InitialImage = null;
            ptbClose.Location = new Point(10, 17);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(15, 24);
            ptbClose.TabIndex = 1;
            ptbClose.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 46, 45);
            panel1.Controls.Add(pnRightTitle);
            panel1.Controls.Add(pnTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 59);
            panel1.TabIndex = 4;
            // 
            // dialogProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(496, 444);
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
            pnRightTitle.ResumeLayout(false);
            pnMini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            pnClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
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
        private Panel pnRightTitle;
        private Panel pnMini;
        private PictureBox ptbMini;
        private Panel pnClose;
        private PictureBox ptbClose;
        private Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}