namespace WinFormsApp1
{
    partial class Lab1_Bai1
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
            Title = new Label();
            soNguyen1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            soNguyen2 = new Label();
            tinhTong = new Button();
            Xoa = new Button();
            Thoat = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            title1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(354, 16);
            Title.Name = "Title";
            Title.Size = new Size(106, 46);
            Title.TabIndex = 0;
            Title.Text = "BÀI 1";
            // 
            // soNguyen1
            // 
            soNguyen1.AutoSize = true;
            soNguyen1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soNguyen1.Location = new Point(132, 140);
            soNguyen1.Name = "soNguyen1";
            soNguyen1.Size = new Size(144, 31);
            soNguyen1.TabIndex = 1;
            soNguyen1.Text = "Số nguyên 1:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(282, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 27);
            textBox2.TabIndex = 5;
            // 
            // soNguyen2
            // 
            soNguyen2.AutoSize = true;
            soNguyen2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soNguyen2.Location = new Point(132, 209);
            soNguyen2.Name = "soNguyen2";
            soNguyen2.Size = new Size(144, 31);
            soNguyen2.TabIndex = 4;
            soNguyen2.Text = "Số nguyên 2:";
            // 
            // tinhTong
            // 
            tinhTong.BackColor = SystemColors.AppWorkspace;
            tinhTong.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tinhTong.ForeColor = SystemColors.ActiveCaptionText;
            tinhTong.Location = new Point(132, 261);
            tinhTong.Name = "tinhTong";
            tinhTong.Size = new Size(174, 45);
            tinhTong.TabIndex = 6;
            tinhTong.Text = "TÍNH TỔNG";
            tinhTong.UseVisualStyleBackColor = false;
            tinhTong.Click += tinhTong_Click;
            // 
            // Xoa
            // 
            Xoa.BackColor = SystemColors.AppWorkspace;
            Xoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.ForeColor = SystemColors.ActiveCaptionText;
            Xoa.Location = new Point(329, 261);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(149, 45);
            Xoa.TabIndex = 7;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = false;
            Xoa.Click += Xoa_Click;
            // 
            // Thoat
            // 
            Thoat.BackColor = SystemColors.AppWorkspace;
            Thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.ForeColor = SystemColors.ActiveCaptionText;
            Thoat.Location = new Point(493, 261);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(164, 45);
            Thoat.TabIndex = 8;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonFace;
            textBox3.Location = new Point(282, 361);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(375, 27);
            textBox3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(132, 357);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 9;
            label1.Text = "Tổng:";
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Location = new Point(282, 62);
            title1.Name = "title1";
            title1.Size = new Size(254, 31);
            title1.TabIndex = 11;
            title1.Text = "Tính tổng 2 số nguyên";
            // 
            // Lab1_Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(title1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(tinhTong);
            Controls.Add(textBox2);
            Controls.Add(soNguyen2);
            Controls.Add(textBox1);
            Controls.Add(soNguyen1);
            Controls.Add(Title);
            Name = "Lab1_Bai1";
            Text = "Lab1_Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label soNguyen1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label soNguyen2;
        private Button tinhTong;
        private Button Xoa;
        private Button Thoat;
        private TextBox textBox3;
        private Label label1;
        private Label title1;
    }
}