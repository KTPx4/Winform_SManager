namespace Essay.Pages.Items
{
    partial class FUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUser));
            pnID = new Panel();
            pnButton = new Panel();
            btnBlock = new Button();
            btnDel = new Button();
            btnViews = new Button();
            pnStatus = new Panel();
            lbStatus = new Label();
            pnSdt = new Panel();
            lbSdt = new Label();
            pnName = new Panel();
            lbName = new Label();
            pnPrivateID = new Panel();
            lbID = new Label();
            pnAvt = new Panel();
            ptbAvt = new PictureBox();
            pnID.SuspendLayout();
            pnButton.SuspendLayout();
            pnStatus.SuspendLayout();
            pnSdt.SuspendLayout();
            pnName.SuspendLayout();
            pnPrivateID.SuspendLayout();
            pnAvt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvt).BeginInit();
            SuspendLayout();
            // 
            // pnID
            // 
            pnID.BackColor = Color.FromArgb(187, 187, 187);
            pnID.Controls.Add(pnButton);
            pnID.Controls.Add(pnStatus);
            pnID.Controls.Add(pnSdt);
            pnID.Controls.Add(pnName);
            pnID.Controls.Add(pnPrivateID);
            pnID.Controls.Add(pnAvt);
            pnID.Location = new Point(0, 0);
            pnID.Name = "pnID";
            pnID.Size = new Size(614, 62);
            pnID.TabIndex = 0;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnBlock);
            pnButton.Controls.Add(btnDel);
            pnButton.Controls.Add(btnViews);
            pnButton.Dock = DockStyle.Left;
            pnButton.Location = new Point(443, 0);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(130, 62);
            pnButton.TabIndex = 18;
            // 
            // btnBlock
            // 
            btnBlock.Location = new Point(55, 20);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(32, 23);
            btnBlock.TabIndex = 1;
            btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.IndianRed;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Location = new Point(13, 20);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(32, 23);
            btnDel.TabIndex = 1;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDelete_Click;
            // 
            // btnViews
            // 
            btnViews.Location = new Point(95, 20);
            btnViews.Name = "btnViews";
            btnViews.Size = new Size(32, 23);
            btnViews.TabIndex = 0;
            btnViews.UseVisualStyleBackColor = true;
            // 
            // pnStatus
            // 
            pnStatus.BackColor = Color.Transparent;
            pnStatus.Controls.Add(lbStatus);
            pnStatus.Dock = DockStyle.Left;
            pnStatus.ForeColor = SystemColors.ButtonFace;
            pnStatus.Location = new Point(395, 0);
            pnStatus.Name = "pnStatus";
            pnStatus.Size = new Size(48, 62);
            pnStatus.TabIndex = 17;
            // 
            // lbStatus
            // 
            lbStatus.BackColor = Color.Transparent;
            lbStatus.Dock = DockStyle.Fill;
            lbStatus.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.Blue;
            lbStatus.Location = new Point(0, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(48, 62);
            lbStatus.TabIndex = 2;
            lbStatus.Text = "Offline";
            lbStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnSdt
            // 
            pnSdt.Controls.Add(lbSdt);
            pnSdt.Dock = DockStyle.Left;
            pnSdt.ForeColor = SystemColors.Control;
            pnSdt.Location = new Point(293, 0);
            pnSdt.Name = "pnSdt";
            pnSdt.Size = new Size(102, 62);
            pnSdt.TabIndex = 14;
            // 
            // lbSdt
            // 
            lbSdt.Dock = DockStyle.Fill;
            lbSdt.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbSdt.ForeColor = Color.Black;
            lbSdt.Location = new Point(0, 0);
            lbSdt.Name = "lbSdt";
            lbSdt.Size = new Size(102, 62);
            lbSdt.TabIndex = 1;
            lbSdt.Text = "0909080705";
            lbSdt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnName
            // 
            pnName.Controls.Add(lbName);
            pnName.Dock = DockStyle.Left;
            pnName.Location = new Point(130, 0);
            pnName.Name = "pnName";
            pnName.Size = new Size(163, 62);
            pnName.TabIndex = 15;
            // 
            // lbName
            // 
            lbName.Dock = DockStyle.Fill;
            lbName.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(0, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(163, 62);
            lbName.TabIndex = 0;
            lbName.Text = "Join Thormash Worker";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnPrivateID
            // 
            pnPrivateID.AutoScroll = true;
            pnPrivateID.Controls.Add(lbID);
            pnPrivateID.Dock = DockStyle.Left;
            pnPrivateID.Location = new Point(48, 0);
            pnPrivateID.Name = "pnPrivateID";
            pnPrivateID.Size = new Size(82, 62);
            pnPrivateID.TabIndex = 16;
            // 
            // lbID
            // 
            lbID.Dock = DockStyle.Fill;
            lbID.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.ForeColor = Color.Black;
            lbID.Location = new Point(0, 0);
            lbID.Name = "lbID";
            lbID.Size = new Size(82, 62);
            lbID.TabIndex = 0;
            lbID.Text = "00101l";
            lbID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnAvt
            // 
            pnAvt.Controls.Add(ptbAvt);
            pnAvt.Dock = DockStyle.Left;
            pnAvt.Location = new Point(0, 0);
            pnAvt.Name = "pnAvt";
            pnAvt.Size = new Size(48, 62);
            pnAvt.TabIndex = 13;
            // 
            // ptbAvt
            // 
            ptbAvt.Dock = DockStyle.Fill;
            ptbAvt.Image = (Image)resources.GetObject("ptbAvt.Image");
            ptbAvt.Location = new Point(0, 0);
            ptbAvt.Name = "ptbAvt";
            ptbAvt.Size = new Size(48, 62);
            ptbAvt.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvt.TabIndex = 0;
            ptbAvt.TabStop = false;
            // 
            // FUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnID);
            Name = "FUser";
            Size = new Size(615, 74);
            Load += User_Load;
            pnID.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnStatus.ResumeLayout(false);
            pnSdt.ResumeLayout(false);
            pnName.ResumeLayout(false);
            pnPrivateID.ResumeLayout(false);
            pnAvt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAvt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnID;
        private Panel pnButton;
        private Button btnBlock;
        private Button btnDel;
        private Button btnViews;
        private Panel pnStatus;
        private Panel pnSdt;
        private Panel pnName;
        private Panel pnPrivateID;
        private Panel pnAvt;
        private PictureBox ptbAvt;
        private Label lbName;
        private Label lbID;
        private Label lbStatus;
        private Label lbSdt;
    }
}
