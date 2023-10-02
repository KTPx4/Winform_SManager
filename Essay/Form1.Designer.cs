namespace Essay
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            htmlTemplateCollection1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            htmlTemplate2 = new DevExpress.Utils.Html.HtmlTemplate();
            alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(components);
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // htmlTemplateCollection1
            // 
            htmlTemplateCollection1.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] { htmlTemplate1, htmlTemplate2 });
            // 
            // htmlTemplate1
            // 
            htmlTemplate1.Name = "htmlTemplate1";
            htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            htmlTemplate1.Template = "<div class=\"box\">\r\n\t<div>text</div>\r\n</div>\r\n\r\n\r\n<!--Glow Button-->\r\n\r\n<div class='button-glow'>Button</div>";
            // 
            // htmlTemplate2
            // 
            htmlTemplate2.Name = "htmlTemplate2";
            htmlTemplate2.Styles = resources.GetString("htmlTemplate2.Styles");
            htmlTemplate2.Template = resources.GetString("htmlTemplate2.Template");
            // 
            // alertControl1
            // 
            alertControl1.AllowHtmlText = true;
            alertControl1.HtmlTemplate.Styles = resources.GetString("alertControl1.HtmlTemplate.Styles");
            alertControl1.HtmlTemplate.Template = resources.GetString("alertControl1.HtmlTemplate.Template");
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(226, 122);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(168, 51);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "simpleButton1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 607);
            ControlBox = false;
            Controls.Add(simpleButton1);
            Cursor = Cursors.No;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.Utils.Html.HtmlTemplateCollection htmlTemplateCollection1;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate1;
        private DevExpress.Utils.Html.HtmlTemplate htmlTemplate2;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}