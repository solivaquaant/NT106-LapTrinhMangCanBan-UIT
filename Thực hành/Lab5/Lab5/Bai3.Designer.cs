namespace Lab5
{
    partial class Bai3
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
            label5 = new Label();
            label4 = new Label();
            textBoxSubject = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxToMail = new TextBox();
            buttonSend = new Button();
            textBoxFromMail = new TextBox();
            richTextBoxBody = new RichTextBox();
            textBoxPsw = new TextBox();
            buttonAttach = new Button();
            richTextBoxAttach = new RichTextBox();
            isMail = new Label();
            isMail2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(19, 251);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 20;
            label5.Text = "Body:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(19, 190);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 19;
            label4.Text = "Subject:";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Font = new Font("Segoe UI", 10F);
            textBoxSubject.Location = new Point(157, 187);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(677, 30);
            textBoxSubject.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(504, 31);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 17;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(69, 99);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 16;
            label2.Text = "To:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(69, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 15;
            label1.Text = "From:";
            // 
            // textBoxToMail
            // 
            textBoxToMail.Font = new Font("Segoe UI", 10F);
            textBoxToMail.Location = new Point(143, 92);
            textBoxToMail.Name = "textBoxToMail";
            textBoxToMail.Size = new Size(284, 30);
            textBoxToMail.TabIndex = 13;
            textBoxToMail.TextChanged += textBoxToMail_TextChanged;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 10F);
            buttonSend.Location = new Point(745, 630);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(89, 46);
            buttonSend.TabIndex = 12;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // textBoxFromMail
            // 
            textBoxFromMail.Font = new Font("Segoe UI", 10F);
            textBoxFromMail.Location = new Point(143, 24);
            textBoxFromMail.Name = "textBoxFromMail";
            textBoxFromMail.Size = new Size(284, 30);
            textBoxFromMail.TabIndex = 11;
            textBoxFromMail.TextChanged += textBoxFromMail_TextChanged;
            // 
            // richTextBoxBody
            // 
            richTextBoxBody.Location = new Point(157, 251);
            richTextBoxBody.Name = "richTextBoxBody";
            richTextBoxBody.Size = new Size(677, 204);
            richTextBoxBody.TabIndex = 21;
            richTextBoxBody.Text = "";
            // 
            // textBoxPsw
            // 
            textBoxPsw.Font = new Font("Segoe UI", 10F);
            textBoxPsw.Location = new Point(594, 24);
            textBoxPsw.Name = "textBoxPsw";
            textBoxPsw.Size = new Size(199, 30);
            textBoxPsw.TabIndex = 14;
            textBoxPsw.UseSystemPasswordChar = true;
            textBoxPsw.TextChanged += textBoxPsw_TextChanged;
            // 
            // buttonAttach
            // 
            buttonAttach.Font = new Font("Segoe UI", 10F);
            buttonAttach.Location = new Point(19, 479);
            buttonAttach.Name = "buttonAttach";
            buttonAttach.Size = new Size(94, 50);
            buttonAttach.TabIndex = 22;
            buttonAttach.Text = "Attach";
            buttonAttach.UseVisualStyleBackColor = true;
            buttonAttach.Click += buttonAttach_Click;
            // 
            // richTextBoxAttach
            // 
            richTextBoxAttach.Location = new Point(157, 479);
            richTextBoxAttach.Name = "richTextBoxAttach";
            richTextBoxAttach.Size = new Size(677, 120);
            richTextBoxAttach.TabIndex = 23;
            richTextBoxAttach.Text = "";
            // 
            // isMail
            // 
            isMail.AutoSize = true;
            isMail.ForeColor = Color.Red;
            isMail.Location = new Point(143, 57);
            isMail.Name = "isMail";
            isMail.Size = new Size(0, 20);
            isMail.TabIndex = 24;
            // 
            // isMail2
            // 
            isMail2.AutoSize = true;
            isMail2.ForeColor = Color.Red;
            isMail2.Location = new Point(143, 125);
            isMail2.Name = "isMail2";
            isMail2.Size = new Size(0, 20);
            isMail2.TabIndex = 25;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 762);
            Controls.Add(isMail2);
            Controls.Add(isMail);
            Controls.Add(richTextBoxAttach);
            Controls.Add(buttonAttach);
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
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private TextBox textBoxSubject;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxToMail;
        private Button buttonSend;
        private TextBox textBoxFromMail;
        private RichTextBox richTextBoxBody;
        private TextBox textBoxPsw;
        private Button buttonAttach;
        private RichTextBox richTextBoxAttach;
        private Label isMail;
        private Label isMail2;
    }
}