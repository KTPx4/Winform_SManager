namespace Essay
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelClose = new DevExpress.XtraEditors.PanelControl();
            ptbClose = new PictureBox();
            panelMini = new DevExpress.XtraEditors.PanelControl();
            ptbMini = new PictureBox();
            panelTitle = new DevExpress.XtraEditors.PanelControl();
            panelLogin = new Components.PanelBoder();
            btnLogin = new Components.ButtonBorder();
            pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelClose).BeginInit();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelMini).BeginInit();
            panelMini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTitle).BeginInit();
            panelTitle.SuspendLayout();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.Transparent;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(panelClose);
            panelControl1.Controls.Add(panelMini);
            panelControl1.Dock = DockStyle.Right;
            panelControl1.Location = new Point(352, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(62, 36);
            panelControl1.TabIndex = 2;
            // 
            // panelClose
            // 
            panelClose.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelClose.Controls.Add(ptbClose);
            panelClose.Dock = DockStyle.Right;
            panelClose.Location = new Point(33, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(29, 36);
            panelClose.TabIndex = 1;
            // 
            // ptbClose
            // 
            ptbClose.BackColor = Color.Transparent;
            ptbClose.BackgroundImage = (Image)resources.GetObject("ptbClose.BackgroundImage");
            ptbClose.BackgroundImageLayout = ImageLayout.Zoom;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Location = new Point(1, 6);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(25, 20);
            ptbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClose.TabIndex = 0;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
            ptbClose.MouseLeave += ptbClose_MouseLeave;
            ptbClose.MouseHover += ptbClose_MouseHover;
            // 
            // panelMini
            // 
            panelMini.Appearance.BackColor = Color.Transparent;
            panelMini.Appearance.Options.UseBackColor = true;
            panelMini.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelMini.Controls.Add(ptbMini);
            panelMini.Dock = DockStyle.Left;
            panelMini.Location = new Point(0, 0);
            panelMini.Name = "panelMini";
            panelMini.Size = new Size(29, 36);
            panelMini.TabIndex = 1;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = Color.Transparent;
            ptbMini.BackgroundImage = (Image)resources.GetObject("ptbMini.BackgroundImage");
            ptbMini.BackgroundImageLayout = ImageLayout.Stretch;
            ptbMini.Cursor = Cursors.Hand;
            ptbMini.Location = new Point(3, 4);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(23, 25);
            ptbMini.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMini.TabIndex = 0;
            ptbMini.TabStop = false;
            ptbMini.Click += ptbMini_Click;
            ptbMini.MouseLeave += ptbMini_MouseLeave;
            ptbMini.MouseHover += ptbMini_MouseHover;
            // 
            // panelTitle
            // 
            panelTitle.Appearance.BackColor = Color.Transparent;
            panelTitle.Appearance.Options.UseBackColor = true;
            panelTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelTitle.Controls.Add(panelControl1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(414, 36);
            panelTitle.TabIndex = 0;
            panelTitle.MouseDown += panelTitle_MouseDown;
            panelTitle.MouseMove += panelTitle_MouseMove;
            panelTitle.MouseUp += panelTitle_MouseUp;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.BorderColor = Color.White;
            panelLogin.BorderRadius = 7;
            panelLogin.BorderSize = 2;
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(pictureEdit2);
            panelLogin.Controls.Add(pictureEdit1);
            panelLogin.Controls.Add(textEdit2);
            panelLogin.Controls.Add(textEdit1);
            panelLogin.Location = new Point(68, 76);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(284, 217);
            panelLogin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundColor = Color.Transparent;
            btnLogin.BorderColor = Color.Fuchsia;
            btnLogin.BorderRadius = 5;
            btnLogin.BorderSize = 2;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Fuchsia;
            btnLogin.Location = new Point(86, 148);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.Fuchsia;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // pictureEdit2
            // 
            pictureEdit2.EditValue = resources.GetObject("pictureEdit2.EditValue");
            pictureEdit2.Location = new Point(34, 94);
            pictureEdit2.Name = "pictureEdit2";
            pictureEdit2.Properties.Appearance.BackColor = Color.Snow;
            pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit2.Size = new Size(36, 40);
            pictureEdit2.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(34, 39);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = Color.Snow;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new Size(36, 40);
            pictureEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(34, 94);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.Appearance.BackColor = Color.Honeydew;
            textEdit2.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textEdit2.Properties.Appearance.Options.UseBackColor = true;
            textEdit2.Properties.Appearance.Options.UseFont = true;
            textEdit2.Properties.AutoHeight = false;
            textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            textEdit2.Properties.Padding = new Padding(37, 0, 0, 0);
            textEdit2.Size = new Size(218, 40);
            textEdit2.TabIndex = 2;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(34, 39);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.Appearance.BackColor = Color.Honeydew;
            textEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textEdit1.Properties.Appearance.Options.UseBackColor = true;
            textEdit1.Properties.Appearance.Options.UseFont = true;
            textEdit1.Properties.AutoHeight = false;
            textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            textEdit1.Properties.Padding = new Padding(37, 0, 0, 0);
            textEdit1.Size = new Size(218, 40);
            textEdit1.TabIndex = 2;
            // 
            // frmLogin
            // 
            Appearance.BackColor = Color.Silver;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayoutStore = ImageLayout.Stretch;
            BackgroundImageStore = (Image)resources.GetObject("$this.BackgroundImageStore");
            ClientSize = new Size(414, 608);
            Controls.Add(panelLogin);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "frmLogin";
            Text = "login";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelClose).EndInit();
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelMini).EndInit();
            panelMini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelTitle).EndInit();
            panelTitle.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelClose;
        private PictureBox ptbClose;
        private DevExpress.XtraEditors.PanelControl panelMini;
        private PictureBox ptbMini;
        private DevExpress.XtraEditors.PanelControl panelTitle;
        private Components.PanelBoder panelLogin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private Components.ButtonBorder btnLogin;
    }
}