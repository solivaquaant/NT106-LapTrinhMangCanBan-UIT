namespace Lab5
{
    partial class Bai1
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
            textBoxFromMail = new TextBox();
            buttonSend = new Button();
            textBoxToMail = new TextBox();
            textBoxPsw = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxSubject = new TextBox();
            label4 = new Label();
            label5 = new Label();
            richTextBoxBody = new RichTextBox();
            SuspendLayout();
            // 
            // textBoxFromMail
            // 
            textBoxFromMail.Font = new Font("Segoe UI", 10F);
            textBoxFromMail.Location = new Point(241, 26);
            textBoxFromMail.Name = "textBoxFromMail";
            textBoxFromMail.Size = new Size(235, 30);
            textBoxFromMail.TabIndex = 0;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 10F);
            buttonSend.Location = new Point(29, 26);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(89, 46);
            buttonSend.TabIndex = 1;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBoxToMail
            // 
            textBoxToMail.Font = new Font("Segoe UI", 10F);
            textBoxToMail.Location = new Point(241, 70);
            textBoxToMail.Name = "textBoxToMail";
            textBoxToMail.Size = new Size(235, 30);
            textBoxToMail.TabIndex = 2;
            // 
            // textBoxPsw
            // 
            textBoxPsw.Font = new Font("Segoe UI", 10F);
            textBoxPsw.Location = new Point(645, 26);
            textBoxPsw.Name = "textBoxPsw";
            textBoxPsw.Size = new Size(199, 30);
            textBoxPsw.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(167, 33);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 4;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(167, 77);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 5;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(555, 33);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Font = new Font("Segoe UI", 10F);
            textBoxSubject.Location = new Point(167, 137);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(677, 30);
            textBoxSubject.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(29, 140);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 8;
            label4.Text = "Subject:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(29, 201);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 9;
            label5.Text = "Body:";
            // 
            // richTextBoxBody
            // 
            richTextBoxBody.Location = new Point(167, 201);
            richTextBoxBody.Name = "richTextBoxBody";
            richTextBoxBody.Size = new Size(677, 222);
            richTextBoxBody.TabIndex = 10;
            richTextBoxBody.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 462);
            Controls.Add(richTextBoxBody);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxSubject);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPsw);
            Controls.Add(textBoxToMail);
            Controls.Add(buttonSend);
            Controls.Add(textBoxFromMail);
            Name = "Bai1";
            Text = "Bài 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFromMail;
        private Button buttonSend;
        private TextBox textBoxToMail;
        private TextBox textBoxPsw;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxSubject;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBoxBody;
    }
}