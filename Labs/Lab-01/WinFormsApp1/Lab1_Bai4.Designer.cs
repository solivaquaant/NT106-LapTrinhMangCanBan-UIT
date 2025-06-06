namespace WinFormsApp1
{
    partial class Lab1_Bai4
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
            title1 = new Label();
            Title = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            Xoa = new Button();
            Thoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Location = new Point(319, 85);
            title1.Name = "title1";
            title1.Size = new Size(165, 31);
            title1.TabIndex = 22;
            title1.Text = "ĐỔI HỆ CƠ SỐ";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(349, 30);
            Title.Name = "Title";
            Title.Size = new Size(106, 46);
            Title.TabIndex = 12;
            Title.Text = "BÀI 4";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(224, 224, 224);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 214);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "NHẬP THÔNG TIN";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(168, 155);
            button1.Name = "button1";
            button1.Size = new Size(552, 40);
            button1.TabIndex = 25;
            button1.Text = "THỰC HIỆN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox2.Location = new Point(488, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(232, 36);
            comboBox2.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 100);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 4;
            label3.Text = "SANG";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox1.Location = new Point(168, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 36);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 93);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 2;
            label2.Text = "Chọn:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(169, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(551, 34);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Nhập 1 số: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 387);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 24;
            label4.Text = "KẾT QUẢ: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 387);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 25;
            // 
            // Xoa
            // 
            Xoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.Location = new Point(483, 381);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(145, 33);
            Xoa.TabIndex = 26;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = true;
            Xoa.Click += Xoa_Click;
            // 
            // Thoat
            // 
            Thoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.Location = new Point(634, 381);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(142, 33);
            Thoat.TabIndex = 27;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Lab1_Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(title1);
            Controls.Add(Title);
            Name = "Lab1_Bai4";
            Text = "Lab1_Bai4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title1;
        private Label Title;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Button Xoa;
        private Button Thoat;
    }
}