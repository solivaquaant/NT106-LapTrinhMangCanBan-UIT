namespace Lab4
{
    partial class Lab4_Bai4
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
            downBut = new Button();
            url_textBox = new TextBox();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonViewSource = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // downBut
            // 
            downBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downBut.Location = new Point(662, 22);
            downBut.Name = "downBut";
            downBut.Size = new Size(110, 27);
            downBut.TabIndex = 8;
            downBut.Text = "DOWNLOAD";
            downBut.UseVisualStyleBackColor = true;
            downBut.Click += downBut_Click;
            // 
            // url_textBox
            // 
            url_textBox.Location = new Point(21, 22);
            url_textBox.Name = "url_textBox";
            url_textBox.Size = new Size(626, 27);
            url_textBox.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 127);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // buttonViewSource
            // 
            buttonViewSource.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewSource.Location = new Point(662, 55);
            buttonViewSource.Name = "buttonViewSource";
            buttonViewSource.Size = new Size(110, 27);
            buttonViewSource.TabIndex = 11;
            buttonViewSource.Text = "XEM SOURCE";
            buttonViewSource.UseVisualStyleBackColor = true;
            buttonViewSource.Click += buttonViewSource_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(21, 88);
            webView.Name = "webView";
            webView.Size = new Size(1083, 512);
            webView.Source = new Uri("https://www.microsoft.com", UriKind.Absolute);
            webView.TabIndex = 12;
            webView.ZoomFactor = 1D;
            // 
            // Lab4_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 631);
            Controls.Add(webView);
            Controls.Add(buttonViewSource);
            Controls.Add(downBut);
            Controls.Add(url_textBox);
            Controls.Add(label1);
            Name = "Lab4_Bai4";
            Text = "Lab4_Bai4";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button downBut;
        private TextBox url_textBox;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonViewSource;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}