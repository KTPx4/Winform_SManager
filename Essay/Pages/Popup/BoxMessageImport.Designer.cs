namespace Essay.Pages.Popup
{
    partial class BoxMessageImport
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
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            dgvReject = new DataGridView();
            btnOk = new Components.ButtonBorder();
            pnTitle = new Panel();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            dgvAdded = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdded).BeginInit();
            SuspendLayout();
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(dgvReject);
            groupControl2.Location = new Point(3, 314);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(767, 266);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "Reject";
            // 
            // dgvReject
            // 
            dgvReject.BackgroundColor = Color.Gainsboro;
            dgvReject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReject.Dock = DockStyle.Fill;
            dgvReject.Location = new Point(2, 23);
            dgvReject.Name = "dgvReject";
            dgvReject.RowTemplate.Height = 25;
            dgvReject.Size = new Size(763, 241);
            dgvReject.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Transparent;
            btnOk.BackgroundColor = Color.Transparent;
            btnOk.BorderColor = Color.DimGray;
            btnOk.BorderRadius = 10;
            btnOk.BorderSize = 2;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.Black;
            btnOk.Location = new Point(332, 589);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 51);
            btnOk.TabIndex = 3;
            btnOk.Text = "Ok";
            btnOk.TextColor = Color.Black;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            btnOk.MouseLeave += btnOk_MouseLeave;
            btnOk.MouseHover += buttonBorder1_MouseHover;
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.FromArgb(56, 56, 56);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(771, 36);
            pnTitle.TabIndex = 4;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(dgvAdded);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 36);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(771, 266);
            groupControl1.TabIndex = 5;
            groupControl1.Text = "Added";
            // 
            // dgvAdded
            // 
            dgvAdded.BackgroundColor = Color.Gainsboro;
            dgvAdded.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdded.Dock = DockStyle.Fill;
            dgvAdded.Location = new Point(2, 23);
            dgvAdded.Name = "dgvAdded";
            dgvAdded.RowTemplate.Height = 25;
            dgvAdded.Size = new Size(767, 241);
            dgvAdded.TabIndex = 0;
            // 
            // BoxMessage
            // 
            Appearance.BackColor = Color.WhiteSmoke;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 648);
            Controls.Add(groupControl1);
            Controls.Add(pnTitle);
            Controls.Add(btnOk);
            Controls.Add(groupControl2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BoxMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BoxMessage";
            Load += BoxMessage_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReject).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAdded).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DataGridView dgvReject;
        private Components.ButtonBorder btnOk;
        private Panel pnTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DataGridView dgvAdded;
    }
}