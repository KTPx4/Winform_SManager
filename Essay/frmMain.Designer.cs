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
            pnNavbar = new Krypton.Toolkit.KryptonPanel();
            pnTittle = new Krypton.Toolkit.KryptonPanel();
            pnContent = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pnNavbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnTittle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnContent).BeginInit();
            SuspendLayout();
            // 
            // pnNavbar
            // 
            pnNavbar.Dock = DockStyle.Left;
            pnNavbar.Location = new Point(0, 0);
            pnNavbar.Name = "pnNavbar";
            pnNavbar.Size = new Size(158, 563);
            pnNavbar.StateCommon.Color1 = Color.FromArgb(41, 39, 40);
            pnNavbar.TabIndex = 0;
            // 
            // pnTittle
            // 
            pnTittle.Dock = DockStyle.Top;
            pnTittle.Location = new Point(158, 0);
            pnTittle.Name = "pnTittle";
            pnTittle.Size = new Size(834, 50);
            pnTittle.StateCommon.Color1 = Color.White;
            pnTittle.TabIndex = 1;
            // 
            // pnContent
            // 
            pnContent.AutoSize = true;
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(158, 50);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(834, 513);
            pnContent.StateCommon.Color1 = Color.White;
            pnContent.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(992, 563);
            Controls.Add(pnContent);
            Controls.Add(pnTittle);
            Controls.Add(pnNavbar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(700, 456);
            Name = "frmMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Text = "SManager";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pnNavbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnTittle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel pnNavbar;
        private Krypton.Toolkit.KryptonPanel pnTittle;
        private Krypton.Toolkit.KryptonPanel pnContent;
    }
}