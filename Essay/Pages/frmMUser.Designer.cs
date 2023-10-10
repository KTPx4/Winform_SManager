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
            splitContainer1 = new SplitContainer();
            pnListItems = new Panel();
            id1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            button1 = new Button();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnListItems);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(kryptonPanel1);
            splitContainer1.Size = new Size(820, 504);
            splitContainer1.SplitterDistance = 576;
            splitContainer1.TabIndex = 0;
            // 
            // pnListItems
            // 
            pnListItems.AutoScroll = true;
            pnListItems.Controls.Add(id1);
            pnListItems.Controls.Add(panel5);
            pnListItems.Dock = DockStyle.Fill;
            pnListItems.Location = new Point(0, 155);
            pnListItems.Name = "pnListItems";
            pnListItems.Size = new Size(576, 349);
            pnListItems.TabIndex = 2;
            // 
            // id1
            // 
            id1.BackColor = Color.DimGray;
            id1.Location = new Point(38, 199);
            id1.Name = "id1";
            id1.Size = new Size(379, 90);
            id1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(576, 0);
            panel5.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(576, 68);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 87);
            panel1.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(button1);
            kryptonPanel1.Controls.Add(kryptonBorderEdge1);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(240, 504);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(31, 166);
            button1.Name = "button1";
            button1.Size = new Size(65, 44);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Dock = DockStyle.Left;
            kryptonBorderEdge1.Location = new Point(0, 0);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Orientation = Orientation.Vertical;
            kryptonBorderEdge1.Size = new Size(1, 504);
            kryptonBorderEdge1.StateCommon.Color1 = Color.LightGray;
            // 
            // frmMUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(splitContainer1);
            Name = "frmMUser";
            Size = new Size(820, 504);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnListItems.ResumeLayout(false);
            pnListItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pnListItems;
        private Panel panel2;
        private Panel panel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Panel panel5;
        private Button button1;
        private Panel id1;
    }
}
