namespace Lab4
{
    partial class Lab4_Bai4_ViewSource
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
            richTextBoxSource = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxSource
            // 
            richTextBoxSource.Location = new Point(36, 43);
            richTextBoxSource.Name = "richTextBoxSource";
            richTextBoxSource.Size = new Size(1043, 541);
            richTextBoxSource.TabIndex = 0;
            richTextBoxSource.Text = "";
            // 
            // Lab4_Bai4_ViewSource
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 631);
            Controls.Add(richTextBoxSource);
            Name = "Lab4_Bai4_ViewSource";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxSource;
    }
}