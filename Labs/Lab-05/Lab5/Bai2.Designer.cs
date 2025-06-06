namespace Lab5
{
    partial class Bai2
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
            label2 = new Label();
            label1 = new Label();
            textBoxPsw = new TextBox();
            textBoxMail = new TextBox();
            buttonLogin = new Button();
            listView1 = new ListView();
            recent = new RichTextBox();
            label4 = new Label();
            total = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // textBoxPsw
            // 
            textBoxPsw.Font = new Font("Segoe UI", 10F);
            textBoxPsw.Location = new Point(129, 56);
            textBoxPsw.Name = "textBoxPsw";
            textBoxPsw.Size = new Size(376, 30);
            textBoxPsw.TabIndex = 7;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Segoe UI", 10F);
            textBoxMail.Location = new Point(129, 12);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(376, 30);
            textBoxMail.TabIndex = 6;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Segoe UI", 15F);
            buttonLogin.Location = new Point(700, 12);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(116, 57);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(52, 169);
            listView1.Name = "listView1";
            listView1.Size = new Size(791, 254);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // recent
            // 
            recent.Location = new Point(463, 122);
            recent.Name = "recent";
            recent.ReadOnly = true;
            recent.Size = new Size(131, 30);
            recent.TabIndex = 14;
            recent.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(372, 124);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 13;
            label4.Text = "Recent";
            // 
            // total
            // 
            total.Location = new Point(136, 122);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(131, 30);
            total.TabIndex = 12;
            total.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(45, 124);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 11;
            label3.Text = "Total";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 462);
            Controls.Add(listView1);
            Controls.Add(recent);
            Controls.Add(label4);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPsw);
            Controls.Add(textBoxMail);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBoxPsw;
        private TextBox textBoxMail;
        private Button buttonLogin;
        private ListView listView1;
        private RichTextBox recent;
        private Label label4;
        private RichTextBox total;
        private Label label3;
    }
}