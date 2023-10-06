namespace Essay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnNavbar = new Krypton.Toolkit.KryptonPanel();
            pnMenuNav = new Panel();
            pnListsNav = new Panel();
            panel6 = new Panel();
            btnReport = new Button();
            panel5 = new Panel();
            btnStudents = new Button();
            panel3 = new Panel();
            btnUsers = new Button();
            panel1 = new Panel();
            btnHome = new Button();
            pnAvt = new Panel();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            lbTypeUser = new Label();
            lbUser = new Label();
            btnProfile = new Krypton.Toolkit.KryptonButton();
            pnTittle = new Krypton.Toolkit.KryptonPanel();
            panelMini = new Krypton.Toolkit.KryptonPanel();
            ptbMini = new PictureBox();
            panelClose = new Krypton.Toolkit.KryptonPanel();
            ptbClose = new PictureBox();
            lbTitleForm = new Krypton.Toolkit.KryptonLabel();
            pnContent = new Krypton.Toolkit.KryptonPanel();
            timerNavBar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pnNavbar).BeginInit();
            pnNavbar.SuspendLayout();
            pnListsNav.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pnAvt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnTittle).BeginInit();
            pnTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelMini).BeginInit();
            panelMini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelClose).BeginInit();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnContent).BeginInit();
            SuspendLayout();
            // 
            // pnNavbar
            // 
            pnNavbar.Controls.Add(pnMenuNav);
            pnNavbar.Controls.Add(pnListsNav);
            pnNavbar.Controls.Add(pnAvt);
            pnNavbar.Dock = DockStyle.Left;
            pnNavbar.Location = new Point(0, 0);
            pnNavbar.MaximumSize = new Size(180, 563);
            pnNavbar.MinimumSize = new Size(54, 563);
            pnNavbar.Name = "pnNavbar";
            pnNavbar.Size = new Size(180, 563);
            pnNavbar.StateCommon.Color1 = Color.FromArgb(52, 58, 64);
            pnNavbar.TabIndex = 0;
            pnNavbar.Paint += pnNavbar_Paint;
            // 
            // pnMenuNav
            // 
            pnMenuNav.BackColor = Color.Transparent;
            pnMenuNav.BackgroundImage = Properties.Resources.icons8_menu_32;
            pnMenuNav.BackgroundImageLayout = ImageLayout.Center;
            pnMenuNav.Cursor = Cursors.Hand;
            pnMenuNav.Dock = DockStyle.Top;
            pnMenuNav.Location = new Point(0, 55);
            pnMenuNav.Name = "pnMenuNav";
            pnMenuNav.Size = new Size(180, 63);
            pnMenuNav.TabIndex = 2;
            pnMenuNav.Click += pnMenuNav_Click;
            pnMenuNav.MouseLeave += pnMenuNav_MouseLeave;
            pnMenuNav.MouseHover += pnMenuNav_MouseHover;
            // 
            // pnListsNav
            // 
            pnListsNav.BackColor = Color.Transparent;
            pnListsNav.Controls.Add(panel6);
            pnListsNav.Controls.Add(panel5);
            pnListsNav.Controls.Add(panel3);
            pnListsNav.Controls.Add(panel1);
            pnListsNav.Dock = DockStyle.Bottom;
            pnListsNav.Location = new Point(0, 124);
            pnListsNav.Name = "pnListsNav";
            pnListsNav.Size = new Size(180, 439);
            pnListsNav.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnReport);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 150);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 10, 0, 0);
            panel6.Size = new Size(180, 55);
            panel6.TabIndex = 4;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Transparent;
            btnReport.Cursor = Cursors.Hand;
            btnReport.Dock = DockStyle.Left;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btnReport.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 86, 97);
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.ForeColor = Color.White;
            btnReport.Image = Properties.Resources.icons8_report_32;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 10);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(5);
            btnReport.Size = new Size(180, 45);
            btnReport.TabIndex = 1;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnStudents);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 101);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 10, 0, 0);
            panel5.Size = new Size(180, 49);
            panel5.TabIndex = 3;
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.Transparent;
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.Dock = DockStyle.Left;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btnStudents.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 86, 97);
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudents.ForeColor = Color.White;
            btnStudents.Image = Properties.Resources.icons8_student_32;
            btnStudents.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudents.Location = new Point(0, 10);
            btnStudents.Name = "btnStudents";
            btnStudents.Padding = new Padding(5);
            btnStudents.Size = new Size(180, 39);
            btnStudents.TabIndex = 2;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUsers);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 10, 0, 0);
            panel3.Size = new Size(180, 49);
            panel3.TabIndex = 2;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Transparent;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Dock = DockStyle.Left;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btnUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 86, 97);
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.White;
            btnUsers.Image = Properties.Resources.icons8_user_32;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 10);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(5);
            btnUsers.Size = new Size(180, 39);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(180, 52);
            panel1.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(76, 86, 97);
            btnHome.Cursor = Cursors.Hand;
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.LightSlateGray;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 86, 97);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.icons8_home_32__0ABEFF;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 10);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5);
            btnHome.Size = new Size(180, 42);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // pnAvt
            // 
            pnAvt.BackColor = Color.Transparent;
            pnAvt.Controls.Add(kryptonBorderEdge1);
            pnAvt.Controls.Add(lbTypeUser);
            pnAvt.Controls.Add(lbUser);
            pnAvt.Controls.Add(btnProfile);
            pnAvt.Cursor = Cursors.Hand;
            pnAvt.Dock = DockStyle.Top;
            pnAvt.Location = new Point(0, 0);
            pnAvt.Name = "pnAvt";
            pnAvt.Size = new Size(180, 55);
            pnAvt.TabIndex = 1;
            pnAvt.MouseLeave += LeaveAvt;
            pnAvt.MouseHover += HoverAvt;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(0, 54);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(180, 1);
            kryptonBorderEdge1.StateCommon.Color1 = Color.White;
            kryptonBorderEdge1.StateCommon.Color2 = Color.FromArgb(192, 255, 255);
            kryptonBorderEdge1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lbTypeUser
            // 
            lbTypeUser.AutoSize = true;
            lbTypeUser.BackColor = Color.Transparent;
            lbTypeUser.Cursor = Cursors.Hand;
            lbTypeUser.ForeColor = Color.Aqua;
            lbTypeUser.Location = new Point(69, 32);
            lbTypeUser.Name = "lbTypeUser";
            lbTypeUser.Size = new Size(43, 15);
            lbTypeUser.TabIndex = 3;
            lbTypeUser.Text = "Admin";
            lbTypeUser.MouseLeave += LeaveAvt;
            lbTypeUser.MouseHover += HoverAvt;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.BackColor = Color.Transparent;
            lbUser.Cursor = Cursors.Hand;
            lbUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUser.ForeColor = Color.White;
            lbUser.Location = new Point(69, 7);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(38, 21);
            lbUser.TabIndex = 3;
            lbUser.Text = "Px4";
            lbUser.MouseLeave += LeaveAvt;
            lbUser.MouseHover += HoverAvt;
            // 
            // btnProfile
            // 
            btnProfile.CornerRoundingRadius = 50F;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Location = new Point(4, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(46, 46);
            btnProfile.StateCommon.Back.Color1 = Color.Transparent;
            btnProfile.StateCommon.Back.Color2 = Color.Transparent;
            btnProfile.StateCommon.Back.Image = (Image)resources.GetObject("btnProfile.StateCommon.Back.Image");
            btnProfile.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnProfile.StateCommon.Border.Color1 = Color.White;
            btnProfile.StateCommon.Border.Color2 = Color.White;
            btnProfile.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnProfile.StateCommon.Border.Rounding = 50F;
            btnProfile.StateCommon.Border.Width = 2;
            btnProfile.StateTracking.Back.Color1 = Color.FromArgb(192, 0, 192);
            btnProfile.TabIndex = 2;
            btnProfile.Values.Text = "";
            btnProfile.MouseLeave += LeaveAvt;
            btnProfile.MouseHover += HoverAvt;
            // 
            // pnTittle
            // 
            pnTittle.Controls.Add(panelMini);
            pnTittle.Controls.Add(panelClose);
            pnTittle.Controls.Add(lbTitleForm);
            pnTittle.Cursor = Cursors.SizeAll;
            pnTittle.Dock = DockStyle.Top;
            pnTittle.Location = new Point(180, 0);
            pnTittle.Name = "pnTittle";
            pnTittle.Size = new Size(812, 53);
            pnTittle.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            pnTittle.StateCommon.Color2 = Color.FromArgb(221, 221, 218);
            pnTittle.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            pnTittle.TabIndex = 1;
            // 
            // panelMini
            // 
            panelMini.Controls.Add(ptbMini);
            panelMini.Dock = DockStyle.Right;
            panelMini.Location = new Point(748, 0);
            panelMini.Name = "panelMini";
            panelMini.Size = new Size(32, 53);
            panelMini.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            panelMini.StateCommon.Color2 = Color.FromArgb(221, 221, 218);
            panelMini.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            panelMini.TabIndex = 3;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = Color.Transparent;
            ptbMini.BackgroundImage = Properties.Resources.substract;
            ptbMini.BackgroundImageLayout = ImageLayout.Stretch;
            ptbMini.Cursor = Cursors.Hand;
            ptbMini.Location = new Point(6, 15);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(20, 24);
            ptbMini.TabIndex = 1;
            ptbMini.TabStop = false;
            ptbMini.Click += ptbMini_Click;
            ptbMini.MouseLeave += ptbMini_MouseLeave;
            ptbMini.MouseHover += ptbMini_MouseHover;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(ptbClose);
            panelClose.Dock = DockStyle.Right;
            panelClose.Location = new Point(780, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(32, 53);
            panelClose.StateCommon.Color1 = Color.FromArgb(74, 112, 122);
            panelClose.StateCommon.Color2 = Color.FromArgb(221, 221, 218);
            panelClose.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            panelClose.TabIndex = 1;
            // 
            // ptbClose
            // 
            ptbClose.BackColor = Color.Transparent;
            ptbClose.BackgroundImage = Properties.Resources.close3;
            ptbClose.BackgroundImageLayout = ImageLayout.Zoom;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Location = new Point(8, 15);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(15, 24);
            ptbClose.TabIndex = 1;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
            ptbClose.MouseLeave += ptbClose_MouseLeave;
            ptbClose.MouseHover += ptbClose_MouseHover;
            // 
            // lbTitleForm
            // 
            lbTitleForm.Location = new Point(324, 11);
            lbTitleForm.Name = "lbTitleForm";
            lbTitleForm.Size = new Size(87, 42);
            lbTitleForm.StateCommon.ShortText.Color1 = Color.MediumBlue;
            lbTitleForm.StateCommon.ShortText.Color2 = Color.Red;
            lbTitleForm.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            lbTitleForm.StateCommon.ShortText.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleForm.TabIndex = 3;
            lbTitleForm.Values.Text = "Home ";
            // 
            // pnContent
            // 
            pnContent.AutoScroll = true;
            pnContent.AutoSize = true;
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(180, 53);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(812, 510);
            pnContent.StateCommon.Color1 = Color.White;
            pnContent.TabIndex = 2;
            // 
            // timerNavBar
            // 
            timerNavBar.Interval = 120;
            timerNavBar.Tick += timerNavBar_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(992, 563);
            Controls.Add(pnContent);
            Controls.Add(pnTittle);
            Controls.Add(pnNavbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 456);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "SManager";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pnNavbar).EndInit();
            pnNavbar.ResumeLayout(false);
            pnListsNav.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnAvt.ResumeLayout(false);
            pnAvt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnTittle).EndInit();
            pnTittle.ResumeLayout(false);
            pnTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelMini).EndInit();
            panelMini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelClose).EndInit();
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel pnNavbar;
        private Krypton.Toolkit.KryptonPanel pnTittle;
        private PictureBox pictureBox3;
        //  private Panel panelClose;
        private PictureBox pictureBox2;
        // private Panel panelMini;
        private PictureBox ptbMini;
        private PictureBox ptbClose;

        private Krypton.Toolkit.KryptonPanel pnContent;
        private Krypton.Toolkit.KryptonLabel lbTitleForm;
        private Panel pnAvt;
        private Panel panel1;
        private Button btnHome;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Label lbUser;
        private Label lbTypeUser;
        private Panel pnListsNav;
        private Panel panel3;
        private Button btnUsers;
        private Panel panel5;
        private Button btnStudents;
        private Panel panel6;
        private Button btnReport;
        private Panel pnMenuNav;
        private System.Windows.Forms.Timer timerNavBar;
        private Krypton.Toolkit.KryptonPanel panelMini;
        private Krypton.Toolkit.KryptonPanel panelClose;
    }
}