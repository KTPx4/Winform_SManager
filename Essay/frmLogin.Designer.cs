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
            panelTitle = new Panel();
            panelLogin = new Components.PanelBoder();
            panel3 = new Panel();
            ptbClear_2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtPass = new TextBox();
            ckShow = new CheckBox();
            panel1 = new Panel();
            ptbClear_1 = new PictureBox();
            txtUser = new TextBox();
            pictureBox4 = new PictureBox();
            btnLogin = new Components.ButtonBorder();
            panel2 = new Panel();
            panelClose = new Panel();
            pictureBox2 = new PictureBox();
            panelMini = new Panel();
            pictureBox1 = new PictureBox();
            panelTitle.SuspendLayout();
            panelLogin.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClear_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClear_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.Transparent;
            panelTitle.Controls.Add(panelLogin);
            panelTitle.Controls.Add(panel2);
            panelTitle.Cursor = Cursors.NoMove2D;
            panelTitle.Dock = DockStyle.Fill;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(366, 513);
            panelTitle.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.Transparent;
            panelLogin.BorderColor = Color.White;
            panelLogin.BorderRadius = 7;
            panelLogin.BorderSize = 2;
            panelLogin.Controls.Add(panel3);
            panelLogin.Controls.Add(ckShow);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Location = new Point(19, 59);
            panelLogin.Margin = new Padding(4, 3, 4, 3);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(331, 205);
            panelLogin.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(ptbClear_2);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtPass);
            panel3.Location = new Point(52, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(229, 47);
            panel3.TabIndex = 5;
            // 
            // ptbClear_2
            // 
            ptbClear_2.BackColor = Color.Transparent;
            ptbClear_2.Cursor = Cursors.Hand;
            ptbClear_2.Image = Properties.Resources.icons8_macos_close_16_black;
            ptbClear_2.Location = new Point(210, 16);
            ptbClear_2.Name = "ptbClear_2";
            ptbClear_2.Size = new Size(15, 16);
            ptbClear_2.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClear_2.TabIndex = 2;
            ptbClear_2.TabStop = false;
            ptbClear_2.Click += ptbClear_2_Click;
            ptbClear_2.MouseLeave += btnClear_Leave;
            ptbClear_2.MouseHover += btnClear_Hover;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(2, 11);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 27);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.MistyRose;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPass.Location = new Point(34, 5);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(174, 37);
            txtPass.TabIndex = 2;
            txtPass.Text = "123456";
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // ckShow
            // 
            ckShow.AutoSize = true;
            ckShow.BackColor = Color.Transparent;
            ckShow.Cursor = Cursors.Hand;
            ckShow.ForeColor = Color.Transparent;
            ckShow.Location = new Point(283, 104);
            ckShow.Name = "ckShow";
            ckShow.Size = new Size(15, 14);
            ckShow.TabIndex = 3;
            ckShow.UseVisualStyleBackColor = false;
            ckShow.CheckedChanged += ckShow_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(ptbClear_1);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(52, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 47);
            panel1.TabIndex = 5;
            // 
            // ptbClear_1
            // 
            ptbClear_1.BackColor = Color.Transparent;
            ptbClear_1.Cursor = Cursors.Hand;
            ptbClear_1.Image = Properties.Resources.icons8_macos_close_16_black;
            ptbClear_1.Location = new Point(210, 15);
            ptbClear_1.Name = "ptbClear_1";
            ptbClear_1.Size = new Size(15, 16);
            ptbClear_1.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClear_1.TabIndex = 2;
            ptbClear_1.TabStop = false;
            ptbClear_1.Click += ptbClear_1_Click;
            ptbClear_1.MouseLeave += btnClear_Leave;
            ptbClear_1.MouseHover += btnClear_Hover;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.MistyRose;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(34, 5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(174, 37);
            txtUser.TabIndex = 1;
            txtUser.Text = "admin";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(2, 11);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 27);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackgroundColor = Color.Transparent;
            btnLogin.BorderColor = Color.Fuchsia;
            btnLogin.BorderRadius = 5;
            btnLogin.BorderSize = 2;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Fuchsia;
            btnLogin.Location = new Point(107, 145);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(115, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.Fuchsia;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += btnLogin_MouseHover;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelClose);
            panel2.Controls.Add(panelMini);
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(66, 39);
            panel2.TabIndex = 5;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox2);
            panelClose.Location = new Point(34, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(32, 39);
            panelClose.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(7, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 24);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += ptbClose_Click;
            pictureBox2.MouseLeave += ptbClose_MouseLeave;
            pictureBox2.MouseHover += ptbClose_MouseHover;
            // 
            // panelMini
            // 
            panelMini.Controls.Add(pictureBox1);
            panelMini.Location = new Point(0, 0);
            panelMini.Name = "panelMini";
            panelMini.Size = new Size(32, 39);
            panelMini.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 24);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += ptbMini_Click;
            pictureBox1.MouseLeave += ptbMini_MouseLeave;
            pictureBox1.MouseHover += ptbMini_MouseHover;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.An_astronaut_on_a_planet_full_of_monsters_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(366, 513);
            Controls.Add(panelTitle);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            panelTitle.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClear_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClear_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitle;
        private Panel panel2;
        private Panel panelClose;
        private PictureBox pictureBox2;
        private Panel panelMini;
        private PictureBox pictureBox1;
        private Components.PanelBoder panelLogin;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Components.ButtonBorder btnLogin;
        private CheckBox ckShow;
        private PictureBox ptbClear_1;
        private PictureBox ptbClear_2;

        private TextBox txtUser;
        private Panel panel1;
        private Panel panel3;
        private TextBox txtPass;
    }
}