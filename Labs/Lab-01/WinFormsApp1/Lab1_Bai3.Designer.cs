namespace WinFormsApp1
{
    partial class Lab1_Bai3
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
            label1 = new Label();
            Title = new Label();
            title2 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            Thoat = new Button();
            Xoa = new Button();
            ReadNum = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 68);
            label1.Name = "label1";
            label1.Size = new Size(326, 31);
            label1.TabIndex = 3;
            label1.Text = "Đọc số nguyên từ 0 đến 9999";
            label1.Click += label1_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(333, 22);
            Title.Name = "Title";
            Title.Size = new Size(106, 46);
            Title.TabIndex = 2;
            Title.Text = "BÀI 3";
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title2.Location = new Point(210, 136);
            title2.Name = "title2";
            title2.Size = new Size(373, 31);
            title2.TabIndex = 4;
            title2.Text = "Nhập vào số nguyên từ 0 đến 9999:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(364, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(219, 320);
            label2.Name = "label2";
            label2.Size = new Size(102, 31);
            label2.TabIndex = 6;
            label2.Text = "Kết quả:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 365);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(373, 27);
            textBox2.TabIndex = 7;
            // 
            // Thoat
            // 
            Thoat.BackColor = SystemColors.AppWorkspace;
            Thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.ForeColor = SystemColors.ActiveCaptionText;
            Thoat.Location = new Point(478, 245);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(105, 45);
            Thoat.TabIndex = 17;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // Xoa
            // 
            Xoa.BackColor = SystemColors.AppWorkspace;
            Xoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.ForeColor = SystemColors.ActiveCaptionText;
            Xoa.Location = new Point(348, 245);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(108, 45);
            Xoa.TabIndex = 16;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = false;
            Xoa.Click += Xoa_Click;
            // 
            // ReadNum
            // 
            ReadNum.BackColor = SystemColors.AppWorkspace;
            ReadNum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadNum.ForeColor = SystemColors.ActiveCaptionText;
            ReadNum.Location = new Point(217, 245);
            ReadNum.Name = "ReadNum";
            ReadNum.Size = new Size(108, 45);
            ReadNum.TabIndex = 15;
            ReadNum.Text = "ĐỌC";
            ReadNum.UseVisualStyleBackColor = false;
            ReadNum.Click += ReadNum_Click;
            // 
            // Lab1_Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(ReadNum);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(title2);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "Lab1_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Title;
        private Label title2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button Thoat;
        private Button Xoa;
        private Button ReadNum;
    }
}