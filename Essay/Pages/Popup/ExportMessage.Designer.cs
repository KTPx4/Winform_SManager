namespace Essay.Pages.Popup
{
    partial class ExportMessage
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "Confirm Export";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 80);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(289, 43);
            label2.TabIndex = 0;
            label2.Text = "You want to export a list of certificates of all or the selected student?";
            // 
            // button3
            // 
            button3.Location = new Point(172, 126);
            button3.Name = "button3";
            button3.Size = new Size(57, 33);
            button3.TabIndex = 0;
            button3.Text = "Current";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(244, 126);
            button2.Name = "button2";
            button2.Size = new Size(57, 33);
            button2.TabIndex = 0;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(99, 126);
            button1.Name = "button1";
            button1.Size = new Size(57, 33);
            button1.TabIndex = 0;
            button1.Text = "All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExportMessage
            // 
            Appearance.BackColor = Color.LightBlue;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 164);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExportMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExportMessage";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}