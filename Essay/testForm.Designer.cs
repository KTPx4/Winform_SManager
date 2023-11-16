namespace Essay
{
    partial class testForm
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
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            dataGridView1 = new DataGridView();
            SID = new DataGridViewTextBoxColumn();
            SName = new DataGridViewTextBoxColumn();
            Class = new DataGridViewTextBoxColumn();
            BirthDay = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(19, 400);
            button7.Name = "button7";
            button7.Size = new Size(102, 36);
            button7.TabIndex = 0;
            button7.Text = "Import";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(19, 442);
            button6.Name = "button6";
            button6.Size = new Size(102, 36);
            button6.TabIndex = 0;
            button6.Text = "Export";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(19, 287);
            button5.Name = "button5";
            button5.Size = new Size(102, 36);
            button5.TabIndex = 0;
            button5.Text = "View Certìicate";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(19, 229);
            button4.Name = "button4";
            button4.Size = new Size(102, 36);
            button4.TabIndex = 0;
            button4.Text = "Add Certificate";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(19, 167);
            button3.Name = "button3";
            button3.Size = new Size(102, 36);
            button3.TabIndex = 0;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(19, 49);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupControl3
            // 
            groupControl3.Appearance.BackColor = Color.Transparent;
            groupControl3.Appearance.Options.UseBackColor = true;
            groupControl3.Controls.Add(button7);
            groupControl3.Controls.Add(button6);
            groupControl3.Controls.Add(button5);
            groupControl3.Controls.Add(button4);
            groupControl3.Controls.Add(button3);
            groupControl3.Controls.Add(button2);
            groupControl3.Controls.Add(button1);
            groupControl3.Location = new Point(8, 0);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(151, 506);
            groupControl3.TabIndex = 4;
            groupControl3.Text = "Controls";
            // 
            // button2
            // 
            button2.Location = new Point(19, 108);
            button2.Name = "button2";
            button2.Size = new Size(102, 36);
            button2.TabIndex = 0;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(14, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(568, 131);
            dataGridView2.TabIndex = 0;
            // 
            // groupControl2
            // 
            groupControl2.Appearance.BackColor = Color.Transparent;
            groupControl2.Appearance.Options.UseBackColor = true;
            groupControl2.Controls.Add(dataGridView2);
            groupControl2.Location = new Point(165, 338);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(587, 168);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "List Certificate";
            // 
            // groupControl1
            // 
            groupControl1.Appearance.BackColor = Color.Transparent;
            groupControl1.Appearance.Options.UseBackColor = true;
            groupControl1.Controls.Add(dataGridView1);
            groupControl1.Location = new Point(165, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(587, 337);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "List Students";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SID, SName, Class, BirthDay, Address, Phone });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(14, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(568, 306);
            dataGridView1.TabIndex = 0;
            // 
            // SID
            // 
            SID.HeaderText = "SID";
            SID.Name = "SID";
            // 
            // SName
            // 
            SName.HeaderText = "Name";
            SName.Name = "SName";
            // 
            // Class
            // 
            Class.HeaderText = "Class";
            Class.Name = "Class";
            // 
            // BirthDay
            // 
            BirthDay.HeaderText = "Birth Day";
            BirthDay.Name = "BirthDay";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // testForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(groupControl3);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "testForm";
            Size = new Size(761, 509);
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Button button2;
        private DataGridView dataGridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SID;
        private DataGridViewTextBoxColumn SName;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn BirthDay;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
    }
}
