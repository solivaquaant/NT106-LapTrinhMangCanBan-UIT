namespace Lab4
{
    partial class Lab4_Bai2
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
            webContent = new RichTextBox();
            POST_button = new Button();
            url_Textbox = new TextBox();
            content_box = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // webContent
            // 
            webContent.Location = new Point(31, 198);
            webContent.Name = "webContent";
            webContent.Size = new Size(745, 253);
            webContent.TabIndex = 5;
            webContent.Text = "";
            // 
            // POST_button
            // 
            POST_button.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            POST_button.Location = new Point(655, 78);
            POST_button.Name = "POST_button";
            POST_button.Size = new Size(121, 74);
            POST_button.TabIndex = 4;
            POST_button.Text = "POST";
            POST_button.UseVisualStyleBackColor = true;
            POST_button.Click += POST_button_Click;
            // 
            // url_Textbox
            // 
            url_Textbox.Location = new Point(30, 61);
            url_Textbox.Name = "url_Textbox";
            url_Textbox.Size = new Size(607, 27);
            url_Textbox.TabIndex = 3;
            // 
            // content_box
            // 
            content_box.Location = new Point(30, 141);
            content_box.Name = "content_box";
            content_box.Size = new Size(607, 27);
            content_box.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(31, 13);
            label1.Name = "label1";
            label1.Size = new Size(59, 35);
            label1.TabIndex = 7;
            label1.Text = "URL";
            // 
            // Lab4_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 476);
            Controls.Add(label1);
            Controls.Add(content_box);
            Controls.Add(webContent);
            Controls.Add(POST_button);
            Controls.Add(url_Textbox);
            Name = "Lab4_Bai2";
            Text = "Lab4_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox webContent;
        private Button POST_button;
        private TextBox url_Textbox;
        private TextBox content_box;
        private Label label1;
    }
}