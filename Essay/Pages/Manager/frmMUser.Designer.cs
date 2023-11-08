namespace Essay.Pages
{
    partial class frmMUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            pnListItems = new FlowLayoutPanel();
            panel1 = new Panel();
            btnReload = new Button();
            cbbType = new ComboBox();
            pictureBox1 = new PictureBox();
            txtFind = new Krypton.Toolkit.KryptonTextBox();
            pnSetCenter = new Panel();
            pnSide = new Krypton.Toolkit.KryptonPanel();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label2 = new Label();
            lbSumAll = new Label();
            lbSumEmployee = new Label();
            lbSumManager = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            btnViewHis = new Button();
            cbbStatus = new ComboBox();
            groupBox1 = new GroupBox();
            btnAddStaff = new Button();
            btnAddManager = new Button();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            searchTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnSide).BeginInit();
            pnSide.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.Transparent;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnListItems);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(pnSetCenter);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnSide);
            splitContainer1.Size = new Size(814, 492);
            splitContainer1.SplitterDistance = 588;
            splitContainer1.TabIndex = 0;
            // 
            // pnListItems
            // 
            pnListItems.AutoScroll = true;
            pnListItems.Dock = DockStyle.Fill;
            pnListItems.Location = new Point(0, 98);
            pnListItems.Margin = new Padding(0);
            pnListItems.Name = "pnListItems";
            pnListItems.Size = new Size(588, 394);
            pnListItems.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReload);
            panel1.Controls.Add(cbbType);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtFind);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(588, 98);
            panel1.TabIndex = 6;
            // 
            // btnReload
            // 
            btnReload.BackgroundImage = Properties.Resources.icons8_reload_16;
            btnReload.BackgroundImageLayout = ImageLayout.Center;
            btnReload.Location = new Point(547, 36);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(34, 26);
            btnReload.TabIndex = 0;
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += Reload_Click;
            // 
            // cbbType
            // 
            cbbType.FormattingEnabled = true;
            cbbType.Items.AddRange(new object[] { "All", "Managers", "Employees" });
            cbbType.Location = new Point(458, 38);
            cbbType.Margin = new Padding(2);
            cbbType.Name = "cbbType";
            cbbType.Size = new Size(82, 23);
            cbbType.TabIndex = 2;
            cbbType.SelectionChangeCommitted += cbbType_SelectionChangeCommitted;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.icons8_find_ios_16_16;
            pictureBox1.Location = new Point(422, 38);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(14, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(26, 32);
            txtFind.Margin = new Padding(2);
            txtFind.MaximumSize = new Size(418, 36);
            txtFind.MinimumSize = new Size(418, 36);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(418, 36);
            txtFind.StateCommon.Border.Color1 = Color.White;
            txtFind.StateCommon.Border.Color2 = Color.White;
            txtFind.StateCommon.Border.ColorAngle = 45F;
            txtFind.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            txtFind.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            txtFind.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFind.StateCommon.Border.Rounding = 15F;
            txtFind.StateCommon.Border.Width = 1;
            txtFind.StateCommon.Content.Padding = new Padding(0, 5, 35, 0);
            txtFind.TabIndex = 0;
            txtFind.TextAlign = HorizontalAlignment.Center;
            txtFind.TextChanged += txtFind_TextChanged;
            // 
            // pnSetCenter
            // 
            pnSetCenter.BackColor = Color.Transparent;
            pnSetCenter.Dock = DockStyle.Left;
            pnSetCenter.Location = new Point(0, 0);
            pnSetCenter.Margin = new Padding(2);
            pnSetCenter.MaximumSize = new Size(46, 504);
            pnSetCenter.MinimumSize = new Size(0, 504);
            pnSetCenter.Name = "pnSetCenter";
            pnSetCenter.Size = new Size(0, 504);
            pnSetCenter.TabIndex = 3;
            // 
            // pnSide
            // 
            pnSide.Controls.Add(groupBox3);
            pnSide.Controls.Add(groupBox2);
            pnSide.Controls.Add(groupBox1);
            pnSide.Controls.Add(kryptonBorderEdge1);
            pnSide.Dock = DockStyle.Fill;
            pnSide.Location = new Point(0, 0);
            pnSide.Margin = new Padding(2);
            pnSide.Name = "pnSide";
            pnSide.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlCustom1;
            pnSide.Size = new Size(222, 492);
            pnSide.StateCommon.Color1 = Color.Transparent;
            pnSide.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(lbSumAll);
            groupBox3.Controls.Add(lbSumEmployee);
            groupBox3.Controls.Add(lbSumManager);
            groupBox3.Controls.Add(label1);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(4, 353);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(218, 134);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Statistics";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 99);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 2;
            label7.Text = "All :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Employee :";
            // 
            // lbSumAll
            // 
            lbSumAll.AutoSize = true;
            lbSumAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSumAll.ForeColor = Color.White;
            lbSumAll.Location = new Point(97, 99);
            lbSumAll.Margin = new Padding(2, 0, 2, 0);
            lbSumAll.Name = "lbSumAll";
            lbSumAll.Size = new Size(62, 15);
            lbSumAll.TabIndex = 4;
            lbSumAll.Text = "20 People";
            // 
            // lbSumEmployee
            // 
            lbSumEmployee.AutoSize = true;
            lbSumEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSumEmployee.ForeColor = Color.White;
            lbSumEmployee.Location = new Point(97, 68);
            lbSumEmployee.Margin = new Padding(2, 0, 2, 0);
            lbSumEmployee.Name = "lbSumEmployee";
            lbSumEmployee.Size = new Size(62, 15);
            lbSumEmployee.TabIndex = 5;
            lbSumEmployee.Text = "10 People";
            // 
            // lbSumManager
            // 
            lbSumManager.AutoSize = true;
            lbSumManager.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSumManager.ForeColor = Color.White;
            lbSumManager.Location = new Point(97, 35);
            lbSumManager.Margin = new Padding(2, 0, 2, 0);
            lbSumManager.Name = "lbSumManager";
            lbSumManager.Size = new Size(62, 15);
            lbSumManager.TabIndex = 6;
            lbSumManager.Text = "10 People";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 7;
            label1.Text = "Manger :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbbStatus);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(2, 206);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(218, 143);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 42);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 1;
            label5.Text = "Status";
            // 
            // btnViewHis
            // 
            btnViewHis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnViewHis.BackColor = Color.MintCream;
            btnViewHis.FlatStyle = FlatStyle.Flat;
            btnViewHis.ForeColor = Color.Black;
            btnViewHis.Location = new Point(23, 129);
            btnViewHis.Margin = new Padding(2);
            btnViewHis.Name = "btnViewHis";
            btnViewHis.Size = new Size(176, 38);
            btnViewHis.TabIndex = 1;
            btnViewHis.Text = "View History ";
            btnViewHis.UseVisualStyleBackColor = false;
            btnViewHis.Click += ViewHistory_Click;
            // 
            // cbbStatus
            // 
            cbbStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Normal", "Locked", "Deleted" });
            cbbStatus.Location = new Point(12, 62);
            cbbStatus.Margin = new Padding(2);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(192, 23);
            cbbStatus.TabIndex = 0;
            cbbStatus.SelectionChangeCommitted += cbbStatus_SelectionChangeCommitted;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnAddStaff);
            groupBox1.Controls.Add(btnViewHis);
            groupBox1.Controls.Add(btnAddManager);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(2, 22);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(218, 178);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control";
            // 
            // btnAddStaff
            // 
            btnAddStaff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddStaff.BackColor = Color.DarkGray;
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.ForeColor = Color.Black;
            btnAddStaff.Location = new Point(23, 76);
            btnAddStaff.Margin = new Padding(2);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(176, 38);
            btnAddStaff.TabIndex = 1;
            btnAddStaff.Text = "Add Staff";
            btnAddStaff.UseVisualStyleBackColor = false;
            btnAddStaff.Click += addStaff_Click;
            // 
            // btnAddManager
            // 
            btnAddManager.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAddManager.BackColor = Color.Aquamarine;
            btnAddManager.FlatStyle = FlatStyle.Flat;
            btnAddManager.ForeColor = Color.Black;
            btnAddManager.Location = new Point(23, 22);
            btnAddManager.Margin = new Padding(2);
            btnAddManager.Name = "btnAddManager";
            btnAddManager.Size = new Size(176, 38);
            btnAddManager.TabIndex = 1;
            btnAddManager.Text = "Add Manager";
            btnAddManager.UseVisualStyleBackColor = false;
            btnAddManager.Click += addManager_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(0, 6);
            kryptonBorderEdge1.Margin = new Padding(2);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Orientation = Orientation.Vertical;
            kryptonBorderEdge1.Size = new Size(1, 498);
            kryptonBorderEdge1.StateCommon.Color1 = Color.WhiteSmoke;
            kryptonBorderEdge1.StateCommon.Color2 = Color.DarkGray;
            kryptonBorderEdge1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            // 
            // searchTimer
            // 
            searchTimer.Interval = 600;
            searchTimer.Tick += searchTimer_Tick;
            // 
            // frmMUser
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "frmMUser";
            Size = new Size(814, 492);
            Load += frmMUser_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnSide).EndInit();
            pnSide.ResumeLayout(false);
            pnSide.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Krypton.Toolkit.KryptonPanel pnSide;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Button btnAddManager;
        private Panel pnSetCenter;
        private FlowLayoutPanel pnListItems;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox txtFind;
        private ComboBox cbbType;
        private Button btnReload;
        private GroupBox groupBox1;
        private Button btnAddStaff;
        private GroupBox groupBox2;
        private Label label5;
        private ComboBox cbbStatus;
        private GroupBox groupBox3;
        private Label label7;
        private Label label2;
        private Label lbSumAll;
        private Label lbSumEmployee;
        private Label lbSumManager;
        private Label label1;
        private System.Windows.Forms.Timer searchTimer;
        private Button btnViewHis;
    }
}
