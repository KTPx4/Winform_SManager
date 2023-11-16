namespace Essay.Pages.Dialog
{
    partial class PopupMessage
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
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            lbCaption = new Label();
            lbMessage = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.White;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 6F;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Width = 0;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.White;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.Silver;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbCaption);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 37);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(lbMessage);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 82);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 44);
            panel3.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gainsboro;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(155, 10);
            btn1.Name = "btn1";
            btn1.Size = new Size(46, 23);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gainsboro;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(207, 10);
            btn2.Name = "btn2";
            btn2.Size = new Size(46, 23);
            btn2.TabIndex = 0;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gainsboro;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(259, 10);
            btn3.Name = "btn3";
            btn3.Size = new Size(46, 23);
            btn3.TabIndex = 0;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // lbCaption
            // 
            lbCaption.AutoSize = true;
            lbCaption.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbCaption.Location = new Point(12, 9);
            lbCaption.Name = "lbCaption";
            lbCaption.Size = new Size(41, 17);
            lbCaption.TabIndex = 0;
            lbCaption.Text = "label1";
            // 
            // lbMessage
            // 
            lbMessage.Dock = DockStyle.Bottom;
            lbMessage.Location = new Point(0, 3);
            lbMessage.Name = "lbMessage";
            lbMessage.Size = new Size(313, 79);
            lbMessage.TabIndex = 0;
            lbMessage.Text = "gggggggggggggggggggggdfgdfgdfgggggggggggggggggggggdfgdfgdfgggggggggggggggggggggdfgdfgdfgggggggggggggggggggggdfgdfgdfgggggggggggggggggggggdfgdfgdf";
            // 
            // PopupMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(313, 163);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PopupMessage";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopupMessage";
            Load += PopupMessage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Panel panel1;
        private Label lbCaption;
        private Panel panel2;
        private Label lbMessage;
        private Panel panel3;
        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}