namespace Lab5
{
    partial class Bai4
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            label1 = new Label();
            textBoxPsw = new TextBox();
            textBoxMail = new TextBox();
            label6 = new Label();
            buttonLogin = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listView1 = new ListView();
            recent = new RichTextBox();
            label4 = new Label();
            total = new RichTextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            isMail2 = new Label();
            richTextBoxAttach = new RichTextBox();
            buttonAttach = new Button();
            richTextBoxBody = new RichTextBox();
            label5 = new Label();
            label7 = new Label();
            textBoxSubject = new TextBox();
            label8 = new Label();
            textBoxToMail = new TextBox();
            buttonSend = new Button();
            isMail = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(553, 23);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 30;
            label3.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(118, 23);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 28;
            label1.Text = "Email:";
            // 
            // textBoxPsw
            // 
            textBoxPsw.Font = new Font("Segoe UI", 10F);
            textBoxPsw.Location = new Point(643, 16);
            textBoxPsw.Name = "textBoxPsw";
            textBoxPsw.Size = new Size(199, 30);
            textBoxPsw.TabIndex = 27;
            textBoxPsw.UseSystemPasswordChar = true;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 10F);
            textBoxMail.Location = new Point(192, 16);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(338, 30);
            textBoxMail.TabIndex = 24;
            textBoxMail.TextChanged += textBoxMail_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 16);
            label6.Name = "label6";
            label6.Size = new Size(99, 35);
            label6.TabIndex = 37;
            label6.Text = "LOGIN";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(1031, 12);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 38;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 78);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1164, 713);
            tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(recent);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(total);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1156, 680);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Your activities";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(33, 79);
            listView1.Name = "listView1";
            listView1.Size = new Size(1117, 595);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // recent
            // 
            recent.Location = new Point(444, 32);
            recent.Name = "recent";
            recent.ReadOnly = true;
            recent.Size = new Size(131, 30);
            recent.TabIndex = 19;
            recent.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(353, 34);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 18;
            label4.Text = "Recent";
            // 
            // total
            // 
            total.Location = new Point(117, 32);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(131, 30);
            total.TabIndex = 17;
            total.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 34);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 16;
            label2.Text = "Total";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(isMail2);
            tabPage2.Controls.Add(richTextBoxAttach);
            tabPage2.Controls.Add(buttonAttach);
            tabPage2.Controls.Add(richTextBoxBody);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBoxSubject);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBoxToMail);
            tabPage2.Controls.Add(buttonSend);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1156, 680);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Send Mail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // isMail2
            // 
            isMail2.AutoSize = true;
            isMail2.ForeColor = Color.Red;
            isMail2.Location = new Point(166, 48);
            isMail2.Name = "isMail2";
            isMail2.Size = new Size(0, 20);
            isMail2.TabIndex = 33;
            // 
            // richTextBoxAttach
            // 
            richTextBoxAttach.Location = new Point(166, 376);
            richTextBoxAttach.Name = "richTextBoxAttach";
            richTextBoxAttach.ReadOnly = true;
            richTextBoxAttach.Size = new Size(957, 120);
            richTextBoxAttach.TabIndex = 32;
            richTextBoxAttach.Text = "";
            // 
            // buttonAttach
            // 
            buttonAttach.Font = new Font("Segoe UI", 10F);
            buttonAttach.Location = new Point(28, 376);
            buttonAttach.Name = "buttonAttach";
            buttonAttach.Size = new Size(94, 50);
            buttonAttach.TabIndex = 31;
            buttonAttach.Text = "Attach";
            buttonAttach.UseVisualStyleBackColor = true;
            buttonAttach.Click += buttonAttach_Click;
            // 
            // richTextBoxBody
            // 
            richTextBoxBody.Location = new Point(166, 148);
            richTextBoxBody.Name = "richTextBoxBody";
            richTextBoxBody.Size = new Size(957, 204);
            richTextBoxBody.TabIndex = 30;
            richTextBoxBody.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(28, 148);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 29;
            label5.Text = "Body:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(28, 87);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 28;
            label7.Text = "Subject:";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Font = new Font("Segoe UI", 10F);
            textBoxSubject.Location = new Point(166, 84);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(957, 30);
            textBoxSubject.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(28, 22);
            label8.Name = "label8";
            label8.Size = new Size(31, 23);
            label8.TabIndex = 26;
            label8.Text = "To:";
            // 
            // textBoxToMail
            // 
            textBoxToMail.Font = new Font("Segoe UI", 10F);
            textBoxToMail.Location = new Point(166, 15);
            textBoxToMail.Name = "textBoxToMail";
            textBoxToMail.Size = new Size(957, 30);
            textBoxToMail.TabIndex = 25;
            textBoxToMail.TextChanged += textBoxToMail_TextChanged;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Segoe UI", 10F);
            buttonSend.Location = new Point(1034, 530);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(89, 46);
            buttonSend.TabIndex = 24;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // isMail
            // 
            isMail.AutoSize = true;
            isMail.ForeColor = Color.Red;
            isMail.Location = new Point(192, 55);
            isMail.Name = "isMail";
            isMail.Size = new Size(0, 20);
            isMail.TabIndex = 21;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 803);
            Controls.Add(isMail);
            Controls.Add(tabControl1);
            Controls.Add(buttonLogin);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxPsw);
            Controls.Add(textBoxMail);
            Name = "Bai4";
            Text = "Bai4";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label1;
        private TextBox textBoxPsw;
        private TextBox textBoxMail;
        private Label label6;
        private Button buttonLogin;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView listView1;
        private RichTextBox recent;
        private Label label4;
        private RichTextBox total;
        private Label label2;
        private RichTextBox richTextBoxAttach;
        private Button buttonAttach;
        private RichTextBox richTextBoxBody;
        private Label label5;
        private Label label7;
        private TextBox textBoxSubject;
        private Label label8;
        private TextBox textBoxToMail;
        private Button buttonSend;
        private Label isMail2;
        private Label isMail;
    }
}