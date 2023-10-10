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
            panel3 = new Panel();
            panel1 = new Panel();
            pnAllNavbar = new Panel();
            pnListsNavs = new Panel();
            pnReport = new Panel();
            btnReport = new Button();
            pnUser = new Panel();
            btnUsers = new Button();
            pnStudent = new Panel();
            btnStudents = new Button();
            pnHome = new Panel();
            btnHome = new Button();
            bdLine1 = new Krypton.Toolkit.KryptonBorderEdge();
            bdLine2 = new Krypton.Toolkit.KryptonBorderEdge();
            pnAvt = new Panel();
            btnProfile = new Krypton.Toolkit.KryptonButton();
            lbTypeUser = new Label();
            lbUser = new Label();
            panel2 = new Panel();
            ptbMini = new PictureBox();
            ptbClose = new PictureBox();
            lbTitleForm = new Krypton.Toolkit.KryptonLabel();
            timerNavBar = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            pnMini = new Panel();
            pnClose = new Panel();
            pnContent = new Panel();
            pnTitle = new Panel();
            ((System.ComponentModel.ISupportInitialize)pnNavbar).BeginInit();
            pnNavbar.SuspendLayout();
            pnAllNavbar.SuspendLayout();
            pnListsNavs.SuspendLayout();
            pnReport.SuspendLayout();
            pnUser.SuspendLayout();
            pnStudent.SuspendLayout();
            pnHome.SuspendLayout();
            pnAvt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            panel4.SuspendLayout();
            pnMini.SuspendLayout();
            pnClose.SuspendLayout();
            pnTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnNavbar
            // 
            pnNavbar.Controls.Add(pnMenuNav);
            pnNavbar.Controls.Add(panel3);
            pnNavbar.Controls.Add(panel1);
            pnNavbar.Controls.Add(pnAllNavbar);
            pnNavbar.Dock = DockStyle.Left;
            pnNavbar.Location = new Point(0, 0);
            pnNavbar.MaximumSize = new Size(172, 563);
            pnNavbar.MinimumSize = new Size(71, 563);
            pnNavbar.Name = "pnNavbar";
            pnNavbar.Size = new Size(172, 563);
            pnNavbar.StateCommon.Color1 = Color.Transparent;
            pnNavbar.TabIndex = 0;
            pnNavbar.Paint += pnNavbar_Paint;
            // 
            // pnMenuNav
            // 
            pnMenuNav.BackColor = Color.Transparent;
            pnMenuNav.BackgroundImage = Properties.Resources.icons8_double_left_16;
            pnMenuNav.BackgroundImageLayout = ImageLayout.Zoom;
            pnMenuNav.Cursor = Cursors.Hand;
            pnMenuNav.Dock = DockStyle.Right;
            pnMenuNav.Location = new Point(152, 418);
            pnMenuNav.Name = "pnMenuNav";
            pnMenuNav.Size = new Size(20, 103);
            pnMenuNav.TabIndex = 12;
            pnMenuNav.Click += pnMenuNav_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(163, 521);
            panel3.Name = "panel3";
            panel3.Size = new Size(9, 42);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(163, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 418);
            panel1.TabIndex = 1;
            // 
            // pnAllNavbar
            // 
            pnAllNavbar.BackColor = Color.FromArgb(45, 46, 45);
            pnAllNavbar.BorderStyle = BorderStyle.FixedSingle;
            pnAllNavbar.Controls.Add(pnListsNavs);
            pnAllNavbar.Controls.Add(bdLine1);
            pnAllNavbar.Controls.Add(bdLine2);
            pnAllNavbar.Controls.Add(pnAvt);
            pnAllNavbar.Dock = DockStyle.Left;
            pnAllNavbar.Location = new Point(0, 0);
            pnAllNavbar.Name = "pnAllNavbar";
            pnAllNavbar.Size = new Size(163, 563);
            pnAllNavbar.TabIndex = 0;
            // 
            // pnListsNavs
            // 
            pnListsNavs.BackColor = Color.Transparent;
            pnListsNavs.Controls.Add(pnReport);
            pnListsNavs.Controls.Add(pnUser);
            pnListsNavs.Controls.Add(pnStudent);
            pnListsNavs.Controls.Add(pnHome);
            pnListsNavs.Dock = DockStyle.Bottom;
            pnListsNavs.Location = new Point(0, 93);
            pnListsNavs.Name = "pnListsNavs";
            pnListsNavs.Size = new Size(161, 468);
            pnListsNavs.TabIndex = 9;
            // 
            // pnReport
            // 
            pnReport.Controls.Add(btnReport);
            pnReport.Dock = DockStyle.Top;
            pnReport.Location = new Point(0, 150);
            pnReport.Name = "pnReport";
            pnReport.Padding = new Padding(0, 10, 0, 0);
            pnReport.Size = new Size(161, 55);
            pnReport.TabIndex = 4;
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
            btnReport.Padding = new Padding(13, 0, 5, 0);
            btnReport.Size = new Size(190, 45);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            // 
            // pnUser
            // 
            pnUser.Controls.Add(btnUsers);
            pnUser.Dock = DockStyle.Top;
            pnUser.Location = new Point(0, 101);
            pnUser.Name = "pnUser";
            pnUser.Padding = new Padding(0, 10, 0, 0);
            pnUser.Size = new Size(161, 49);
            pnUser.TabIndex = 2;
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
            btnUsers.Padding = new Padding(13, 0, 5, 0);
            btnUsers.Size = new Size(190, 39);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // pnStudent
            // 
            pnStudent.Controls.Add(btnStudents);
            pnStudent.Dock = DockStyle.Top;
            pnStudent.Location = new Point(0, 52);
            pnStudent.Name = "pnStudent";
            pnStudent.Padding = new Padding(0, 10, 0, 0);
            pnStudent.Size = new Size(161, 49);
            pnStudent.TabIndex = 3;
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
            btnStudents.Padding = new Padding(13, 0, 5, 0);
            btnStudents.Size = new Size(190, 39);
            btnStudents.TabIndex = 3;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            // 
            // pnHome
            // 
            pnHome.BackColor = Color.Transparent;
            pnHome.Controls.Add(btnHome);
            pnHome.Dock = DockStyle.Top;
            pnHome.Location = new Point(0, 0);
            pnHome.Name = "pnHome";
            pnHome.Padding = new Padding(0, 10, 0, 0);
            pnHome.Size = new Size(161, 52);
            pnHome.TabIndex = 1;
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
            btnHome.Padding = new Padding(13, 0, 5, 0);
            btnHome.Size = new Size(190, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // bdLine1
            // 
            bdLine1.Location = new Point(34, 72);
            bdLine1.Name = "bdLine1";
            bdLine1.Size = new Size(98, 1);
            bdLine1.StateCommon.Color1 = Color.White;
            bdLine1.StateCommon.Color2 = Color.FromArgb(192, 255, 255);
            bdLine1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            bdLine1.Text = "kryptonBorderEdge1";
            bdLine1.Paint += bdLine1_Paint;
            // 
            // bdLine2
            // 
            bdLine2.Dock = DockStyle.Top;
            bdLine2.Location = new Point(0, 72);
            bdLine2.Name = "bdLine2";
            bdLine2.Size = new Size(161, 1);
            bdLine2.StateCommon.Color1 = Color.White;
            bdLine2.StateCommon.Color2 = Color.FromArgb(192, 255, 255);
            bdLine2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            bdLine2.Text = "kryptonBorderEdge1";
            // 
            // pnAvt
            // 
            pnAvt.Controls.Add(btnProfile);
            pnAvt.Controls.Add(lbTypeUser);
            pnAvt.Controls.Add(lbUser);
            pnAvt.Dock = DockStyle.Top;
            pnAvt.Location = new Point(0, 0);
            pnAvt.Name = "pnAvt";
            pnAvt.Size = new Size(161, 72);
            pnAvt.TabIndex = 4;
            // 
            // btnProfile
            // 
            btnProfile.CornerRoundingRadius = 50F;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Location = new Point(13, 8);
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
            // lbTypeUser
            // 
            lbTypeUser.AutoSize = true;
            lbTypeUser.BackColor = Color.Transparent;
            lbTypeUser.Cursor = Cursors.Hand;
            lbTypeUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTypeUser.ForeColor = Color.Aqua;
            lbTypeUser.Location = new Point(68, 34);
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
            lbUser.Location = new Point(68, 9);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(38, 21);
            lbUser.TabIndex = 3;
            lbUser.Text = "Px4";
            lbUser.MouseLeave += LeaveAvt;
            lbUser.MouseHover += HoverAvt;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(17, 73);
            panel2.TabIndex = 4;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = Color.Transparent;
            ptbMini.BackgroundImage = Properties.Resources.substract;
            ptbMini.BackgroundImageLayout = ImageLayout.Stretch;
            ptbMini.Cursor = Cursors.Hand;
            ptbMini.Location = new Point(8, 25);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(20, 24);
            ptbMini.TabIndex = 1;
            ptbMini.TabStop = false;
            ptbMini.Click += ptbMini_Click;
            ptbMini.MouseLeave += ptbMini_MouseLeave;
            ptbMini.MouseHover += ptbMini_MouseHover;
            // 
            // ptbClose
            // 
            ptbClose.BackColor = Color.Transparent;
            ptbClose.BackgroundImage = Properties.Resources.close3;
            ptbClose.BackgroundImageLayout = ImageLayout.Zoom;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Location = new Point(10, 25);
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
            lbTitleForm.Location = new Point(17, 11);
            lbTitleForm.Name = "lbTitleForm";
            lbTitleForm.Size = new Size(87, 42);
            lbTitleForm.StateCommon.ShortText.Color1 = Color.Linen;
            lbTitleForm.StateCommon.ShortText.Color2 = Color.LightSkyBlue;
            lbTitleForm.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            lbTitleForm.StateCommon.ShortText.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleForm.TabIndex = 3;
            lbTitleForm.Values.Text = "Home ";
            // 
            // timerNavBar
            // 
            timerNavBar.Interval = 120;
            timerNavBar.Tick += timerNavBar_Tick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(pnMini);
            panel4.Controls.Add(pnClose);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(843, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(149, 73);
            panel4.TabIndex = 0;
            // 
            // pnMini
            // 
            pnMini.BackColor = Color.Transparent;
            pnMini.Controls.Add(ptbMini);
            pnMini.Dock = DockStyle.Right;
            pnMini.Location = new Point(77, 0);
            pnMini.Name = "pnMini";
            pnMini.Size = new Size(36, 73);
            pnMini.TabIndex = 5;
            // 
            // pnClose
            // 
            pnClose.BackColor = Color.Transparent;
            pnClose.Controls.Add(ptbClose);
            pnClose.Dock = DockStyle.Right;
            pnClose.Location = new Point(113, 0);
            pnClose.Name = "pnClose";
            pnClose.Size = new Size(36, 73);
            pnClose.TabIndex = 4;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Bottom;
            pnContent.Location = new Point(172, 73);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(820, 490);
            pnContent.TabIndex = 2;
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.Transparent;
            pnTitle.Controls.Add(lbTitleForm);
            pnTitle.Dock = DockStyle.Left;
            pnTitle.Location = new Point(172, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(665, 73);
            pnTitle.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(992, 563);
            Controls.Add(pnTitle);
            Controls.Add(panel4);
            Controls.Add(pnContent);
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
            pnAllNavbar.ResumeLayout(false);
            pnAllNavbar.PerformLayout();
            pnListsNavs.ResumeLayout(false);
            pnReport.ResumeLayout(false);
            pnUser.ResumeLayout(false);
            pnStudent.ResumeLayout(false);
            pnHome.ResumeLayout(false);
            pnAvt.ResumeLayout(false);
            pnAvt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            panel4.ResumeLayout(false);
            pnMini.ResumeLayout(false);
            pnClose.ResumeLayout(false);
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel pnNavbar;
        private PictureBox pictureBox3;
        //  private Panel panelClose;
        private PictureBox pictureBox2;
        // private Panel panelMini;
        private PictureBox ptbMini;
        private PictureBox ptbClose;
        private Krypton.Toolkit.KryptonLabel lbTitleForm;
        private Krypton.Toolkit.KryptonButton btnProfile;
        private Label lbUser;
        private Label lbTypeUser;
        private System.Windows.Forms.Timer timerNavBar;
        //  private Krypton.Toolkit.KryptonPanel panelMini;
        // private Krypton.Toolkit.KryptonPanel pnClose;
        private Krypton.Toolkit.KryptonBorderEdge bdLine1;
        private Panel pnAvt;
        private Krypton.Toolkit.KryptonBorderEdge bdLine2;
        private Panel pnMenuNav;
        private Panel panel1;
        private Panel pnAllNavbar;
        private Panel pnListsNavs;
        private Panel pnReport;
        private Button btnReport;
        private Panel pnUser;
        private Button btnUsers;
        private Panel pnStudent;
        private Button btnStudents;
        private Panel pnHome;
        private Button btnHome;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel pnContent;
        private Panel pnTitle;
        private Panel panel7;
        private Panel pnClose;
        private Panel pnMini;
    }
}