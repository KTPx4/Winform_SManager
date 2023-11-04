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
            pn2 = new Panel();
            pn1 = new Panel();
            panel2 = new Panel();
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
            lbName = new Label();
            pnContent = new Panel();
            pnTitle = new Panel();
            lbTitleForm = new Krypton.Toolkit.KryptonLabel();
            pnRightTitle = new Panel();
            pnMini = new Panel();
            ptbMini = new PictureBox();
            pnClose = new Panel();
            ptbClose = new PictureBox();
            timerNavBar = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pnNavbar).BeginInit();
            pnNavbar.SuspendLayout();
            pn1.SuspendLayout();
            pnAllNavbar.SuspendLayout();
            pnListsNavs.SuspendLayout();
            pnReport.SuspendLayout();
            pnUser.SuspendLayout();
            pnStudent.SuspendLayout();
            pnHome.SuspendLayout();
            pnAvt.SuspendLayout();
            pnTitle.SuspendLayout();
            pnRightTitle.SuspendLayout();
            pnMini.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbMini).BeginInit();
            pnClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnNavbar
            // 
            pnNavbar.Controls.Add(pnMenuNav);
            pnNavbar.Controls.Add(pn2);
            pnNavbar.Controls.Add(pn1);
            pnNavbar.Controls.Add(pnAllNavbar);
            pnNavbar.Dock = DockStyle.Left;
            pnNavbar.Location = new Point(0, 0);
            pnNavbar.Margin = new Padding(2, 3, 2, 3);
            pnNavbar.MaximumSize = new Size(164, 626);
            pnNavbar.MinimumSize = new Size(67, 626);
            pnNavbar.Name = "pnNavbar";
            pnNavbar.Size = new Size(164, 626);
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
            pnMenuNav.Location = new Point(145, 465);
            pnMenuNav.Margin = new Padding(2, 3, 2, 3);
            pnMenuNav.Name = "pnMenuNav";
            pnMenuNav.Size = new Size(19, 115);
            pnMenuNav.TabIndex = 12;
            pnMenuNav.Click += pnMenuNav_Click;
            pnMenuNav.MouseLeave += pnMenuNav_MouseLeave;
            pnMenuNav.MouseHover += pnMenuNav_MouseHover;
            // 
            // pn2
            // 
            pn2.Dock = DockStyle.Bottom;
            pn2.Location = new Point(156, 580);
            pn2.Margin = new Padding(2, 3, 2, 3);
            pn2.Name = "pn2";
            pn2.Size = new Size(8, 46);
            pn2.TabIndex = 2;
            // 
            // pn1
            // 
            pn1.Controls.Add(panel2);
            pn1.Dock = DockStyle.Top;
            pn1.Location = new Point(156, 0);
            pn1.Margin = new Padding(2, 3, 2, 3);
            pn1.Name = "pn1";
            pn1.Size = new Size(8, 465);
            pn1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(7, 178);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 285);
            panel2.TabIndex = 0;
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
            pnAllNavbar.Margin = new Padding(2, 3, 2, 3);
            pnAllNavbar.Name = "pnAllNavbar";
            pnAllNavbar.Size = new Size(156, 626);
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
            pnListsNavs.Location = new Point(0, 104);
            pnListsNavs.Margin = new Padding(2, 3, 2, 3);
            pnListsNavs.Name = "pnListsNavs";
            pnListsNavs.Size = new Size(154, 520);
            pnListsNavs.TabIndex = 9;
            // 
            // pnReport
            // 
            pnReport.Controls.Add(btnReport);
            pnReport.Dock = DockStyle.Top;
            pnReport.Location = new Point(0, 166);
            pnReport.Margin = new Padding(2, 3, 2, 3);
            pnReport.Name = "pnReport";
            pnReport.Padding = new Padding(0, 11, 0, 0);
            pnReport.Size = new Size(154, 62);
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
            btnReport.Location = new Point(0, 11);
            btnReport.Margin = new Padding(2, 3, 2, 3);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(13, 0, 5, 0);
            btnReport.Size = new Size(181, 51);
            btnReport.TabIndex = 4;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.MouseLeave += LeaveHoverBtn;
            btnReport.MouseHover += HoverBtn;
            // 
            // pnUser
            // 
            pnUser.Controls.Add(btnUsers);
            pnUser.Dock = DockStyle.Top;
            pnUser.Location = new Point(0, 112);
            pnUser.Margin = new Padding(2, 3, 2, 3);
            pnUser.Name = "pnUser";
            pnUser.Padding = new Padding(0, 11, 0, 0);
            pnUser.Size = new Size(154, 54);
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
            btnUsers.Location = new Point(0, 11);
            btnUsers.Margin = new Padding(2, 3, 2, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(13, 0, 5, 0);
            btnUsers.Size = new Size(181, 43);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            btnUsers.MouseLeave += LeaveHoverBtn;
            btnUsers.MouseHover += HoverBtn;
            // 
            // pnStudent
            // 
            pnStudent.Controls.Add(btnStudents);
            pnStudent.Dock = DockStyle.Top;
            pnStudent.Location = new Point(0, 58);
            pnStudent.Margin = new Padding(2, 3, 2, 3);
            pnStudent.Name = "pnStudent";
            pnStudent.Padding = new Padding(0, 11, 0, 0);
            pnStudent.Size = new Size(154, 54);
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
            btnStudents.Location = new Point(0, 11);
            btnStudents.Margin = new Padding(2, 3, 2, 3);
            btnStudents.Name = "btnStudents";
            btnStudents.Padding = new Padding(13, 0, 5, 0);
            btnStudents.Size = new Size(181, 43);
            btnStudents.TabIndex = 3;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.MouseLeave += LeaveHoverBtn;
            btnStudents.MouseHover += HoverBtn;
            // 
            // pnHome
            // 
            pnHome.BackColor = Color.Transparent;
            pnHome.Controls.Add(btnHome);
            pnHome.Dock = DockStyle.Top;
            pnHome.Location = new Point(0, 0);
            pnHome.Margin = new Padding(2, 3, 2, 3);
            pnHome.Name = "pnHome";
            pnHome.Padding = new Padding(0, 11, 0, 0);
            pnHome.Size = new Size(154, 58);
            pnHome.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
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
            btnHome.Location = new Point(0, 11);
            btnHome.Margin = new Padding(2, 3, 2, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(13, 0, 5, 0);
            btnHome.Size = new Size(181, 47);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            btnHome.MouseLeave += LeaveHoverBtn;
            btnHome.MouseHover += HoverBtn;
            // 
            // bdLine1
            // 
            bdLine1.Location = new Point(33, 80);
            bdLine1.Margin = new Padding(2, 3, 2, 3);
            bdLine1.Name = "bdLine1";
            bdLine1.Size = new Size(94, 1);
            bdLine1.StateCommon.Color1 = Color.White;
            bdLine1.StateCommon.Color2 = Color.FromArgb(192, 255, 255);
            bdLine1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            bdLine1.Text = "kryptonBorderEdge1";
            // 
            // bdLine2
            // 
            bdLine2.Dock = DockStyle.Top;
            bdLine2.Location = new Point(0, 80);
            bdLine2.Margin = new Padding(2, 3, 2, 3);
            bdLine2.Name = "bdLine2";
            bdLine2.Size = new Size(154, 1);
            bdLine2.StateCommon.Color1 = Color.White;
            bdLine2.StateCommon.Color2 = Color.FromArgb(192, 255, 255);
            bdLine2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            bdLine2.Text = "kryptonBorderEdge1";
            // 
            // pnAvt
            // 
            pnAvt.Controls.Add(btnProfile);
            pnAvt.Controls.Add(lbTypeUser);
            pnAvt.Controls.Add(lbName);
            pnAvt.Dock = DockStyle.Top;
            pnAvt.Location = new Point(0, 0);
            pnAvt.Margin = new Padding(2, 3, 2, 3);
            pnAvt.Name = "pnAvt";
            pnAvt.Size = new Size(154, 80);
            pnAvt.TabIndex = 4;
            pnAvt.Click += btnProfile_Click;
            // 
            // btnProfile
            // 
            btnProfile.CornerRoundingRadius = 50F;
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Location = new Point(13, 9);
            btnProfile.Margin = new Padding(2, 3, 2, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(44, 44);
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
            btnProfile.Click += btnProfile_Click;
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
            lbTypeUser.Location = new Point(65, 38);
            lbTypeUser.Margin = new Padding(2, 0, 2, 0);
            lbTypeUser.Name = "lbTypeUser";
            lbTypeUser.Size = new Size(43, 15);
            lbTypeUser.TabIndex = 3;
            lbTypeUser.Text = "Admin";
            lbTypeUser.Click += btnProfile_Click;
            lbTypeUser.MouseLeave += LeaveAvt;
            lbTypeUser.MouseHover += HoverAvt;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Cursor = Cursors.Hand;
            lbName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(65, 10);
            lbName.Margin = new Padding(2, 0, 2, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(38, 21);
            lbName.TabIndex = 3;
            lbName.Text = "Px4";
            lbName.Click += btnProfile_Click;
            lbName.MouseLeave += LeaveAvt;
            lbName.MouseHover += HoverAvt;
            // 
            // pnContent
            // 
            pnContent.BackColor = Color.FromArgb(40, 40, 40);
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(2, 75);
            pnContent.Margin = new Padding(2, 3, 2, 3);
            pnContent.MinimumSize = new Size(775, 546);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(777, 548);
            pnContent.TabIndex = 2;
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.Transparent;
            pnTitle.Controls.Add(lbTitleForm);
            pnTitle.Dock = DockStyle.Left;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Margin = new Padding(2, 3, 2, 3);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(562, 66);
            pnTitle.TabIndex = 3;
            // 
            // lbTitleForm
            // 
            lbTitleForm.Location = new Point(16, 12);
            lbTitleForm.Margin = new Padding(2, 3, 2, 3);
            lbTitleForm.Name = "lbTitleForm";
            lbTitleForm.Size = new Size(87, 42);
            lbTitleForm.StateCommon.ShortText.Color1 = Color.Linen;
            lbTitleForm.StateCommon.ShortText.Color2 = Color.LightSkyBlue;
            lbTitleForm.StateCommon.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            lbTitleForm.StateCommon.ShortText.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleForm.TabIndex = 3;
            lbTitleForm.Values.Text = "Home ";
            // 
            // pnRightTitle
            // 
            pnRightTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnRightTitle.BackColor = Color.Transparent;
            pnRightTitle.Controls.Add(pnMini);
            pnRightTitle.Controls.Add(pnClose);
            pnRightTitle.Location = new Point(628, 2);
            pnRightTitle.Margin = new Padding(2, 3, 2, 3);
            pnRightTitle.Name = "pnRightTitle";
            pnRightTitle.Size = new Size(146, 62);
            pnRightTitle.TabIndex = 0;
            // 
            // pnMini
            // 
            pnMini.BackColor = Color.Transparent;
            pnMini.Controls.Add(ptbMini);
            pnMini.Location = new Point(74, 0);
            pnMini.Margin = new Padding(2, 3, 2, 3);
            pnMini.Name = "pnMini";
            pnMini.Size = new Size(34, 58);
            pnMini.TabIndex = 5;
            // 
            // ptbMini
            // 
            ptbMini.BackColor = Color.Transparent;
            ptbMini.BackgroundImage = Properties.Resources.icons8_minus_material_filled_32;
            ptbMini.BackgroundImageLayout = ImageLayout.Stretch;
            ptbMini.Cursor = Cursors.Hand;
            ptbMini.Location = new Point(7, 18);
            ptbMini.Margin = new Padding(2, 3, 2, 3);
            ptbMini.Name = "ptbMini";
            ptbMini.Size = new Size(19, 26);
            ptbMini.TabIndex = 1;
            ptbMini.TabStop = false;
            ptbMini.Click += ptbMini_Click;
            ptbMini.MouseLeave += ptbMini_MouseLeave;
            ptbMini.MouseHover += ptbMini_MouseHover;
            // 
            // pnClose
            // 
            pnClose.BackColor = Color.Transparent;
            pnClose.Controls.Add(ptbClose);
            pnClose.Location = new Point(107, 0);
            pnClose.Margin = new Padding(2, 3, 2, 3);
            pnClose.Name = "pnClose";
            pnClose.Size = new Size(34, 58);
            pnClose.TabIndex = 4;
            // 
            // ptbClose
            // 
            ptbClose.BackColor = Color.Transparent;
            ptbClose.BackgroundImage = Properties.Resources.icons8_close_ios_16_filled_321;
            ptbClose.BackgroundImageLayout = ImageLayout.Zoom;
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.InitialImage = null;
            ptbClose.Location = new Point(10, 18);
            ptbClose.Margin = new Padding(2, 3, 2, 3);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(14, 26);
            ptbClose.TabIndex = 1;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
            ptbClose.MouseLeave += ptbClose_MouseLeave;
            ptbClose.MouseHover += ptbClose_MouseHover;
            // 
            // timerNavBar
            // 
            timerNavBar.Interval = 130;
            timerNavBar.Tick += timerNavBar_Tick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.Controls.Add(pnContent, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(164, 0);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5452929F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.4547043F));
            tableLayoutPanel1.Size = new Size(781, 626);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnRightTitle);
            panel1.Controls.Add(pnTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 3);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 66);
            panel1.TabIndex = 3;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(945, 626);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnNavbar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MinimumSize = new Size(666, 506);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "SManager";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pnNavbar).EndInit();
            pnNavbar.ResumeLayout(false);
            pn1.ResumeLayout(false);
            pnAllNavbar.ResumeLayout(false);
            pnAllNavbar.PerformLayout();
            pnListsNavs.ResumeLayout(false);
            pnReport.ResumeLayout(false);
            pnUser.ResumeLayout(false);
            pnStudent.ResumeLayout(false);
            pnHome.ResumeLayout(false);
            pnAvt.ResumeLayout(false);
            pnAvt.PerformLayout();
            pnTitle.ResumeLayout(false);
            pnTitle.PerformLayout();
            pnRightTitle.ResumeLayout(false);
            pnMini.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbMini).EndInit();
            pnClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Label lbName;
        private Label lbTypeUser;
        private System.Windows.Forms.Timer timerNavBar;
        //  private Krypton.Toolkit.KryptonPanel panelMini;
        // private Krypton.Toolkit.KryptonPanel pnClose;
        private Krypton.Toolkit.KryptonBorderEdge bdLine1;
        private Panel pnAvt;
        private Krypton.Toolkit.KryptonBorderEdge bdLine2;
        private Panel pnMenuNav;
        private Panel pn1;
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
        private Panel pn2;
        private Panel pnRightTitle;
        private Panel pnContent;
        private Panel pnTitle;
        private Panel pnClose;
        private Panel pnMini;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
    }
}