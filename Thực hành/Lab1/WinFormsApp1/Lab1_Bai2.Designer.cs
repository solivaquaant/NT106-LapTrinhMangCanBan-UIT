namespace WinFormsApp1
{
    partial class Lab1_Bai2
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
            label1 = new Label();
            textBox2 = new TextBox();
            soNguyen2 = new Label();
            textBox1 = new TextBox();
            soNguyen1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            Thoat = new Button();
            Xoa = new Button();
            timMinMax = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(346, 20);
            Title.Name = "Title";
            Title.Size = new Size(106, 46);
            Title.TabIndex = 0;
            Title.Text = "BÀI 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 66);
            label1.Name = "label1";
            label1.Size = new Size(382, 31);
            label1.TabIndex = 1;
            label1.Text = "Tìm số lớn nhất, nhỏ nhất của 3 số";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(344, 27);
            textBox2.TabIndex = 9;
            // 
            // soNguyen2
            // 
            soNguyen2.AutoSize = true;
            soNguyen2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soNguyen2.Location = new Point(142, 172);
            soNguyen2.Name = "soNguyen2";
            soNguyen2.Size = new Size(122, 31);
            soNguyen2.TabIndex = 8;
            soNguyen2.Text = "Số thứ hai:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(285, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(344, 27);
            textBox1.TabIndex = 7;
            // 
            // soNguyen1
            // 
            soNguyen1.AutoSize = true;
            soNguyen1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soNguyen1.Location = new Point(142, 123);
            soNguyen1.Name = "soNguyen1";
            soNguyen1.Size = new Size(137, 31);
            soNguyen1.TabIndex = 6;
            soNguyen1.Text = "Số thứ nhất:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(285, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(344, 27);
            textBox3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 221);
            label2.Name = "label2";
            label2.Size = new Size(117, 31);
            label2.TabIndex = 10;
            label2.Text = "Số thứ ba:";
            // 
            // Thoat
            // 
            Thoat.BackColor = SystemColors.AppWorkspace;
            Thoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Thoat.ForeColor = SystemColors.ActiveCaptionText;
            Thoat.Location = new Point(506, 280);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(123, 45);
            Thoat.TabIndex = 14;
            Thoat.Text = "THOÁT";
            Thoat.UseVisualStyleBackColor = false;
            Thoat.Click += Thoat_Click;
            // 
            // Xoa
            // 
            Xoa.BackColor = SystemColors.AppWorkspace;
            Xoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.ForeColor = SystemColors.ActiveCaptionText;
            Xoa.Location = new Point(331, 280);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(132, 45);
            Xoa.TabIndex = 13;
            Xoa.Text = "XOÁ";
            Xoa.UseVisualStyleBackColor = false;
            Xoa.Click += Xoa_Click;
            // 
            // timMinMax
            // 
            timMinMax.BackColor = SystemColors.AppWorkspace;
            timMinMax.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timMinMax.ForeColor = SystemColors.ActiveCaptionText;
            timMinMax.Location = new Point(142, 280);
            timMinMax.Name = "timMinMax";
            timMinMax.Size = new Size(154, 45);
            timMinMax.TabIndex = 12;
            timMinMax.Text = "TÌM";
            timMinMax.UseVisualStyleBackColor = false;
            timMinMax.Click += timMinMax_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(215, 358);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 352);
            label3.Name = "label3";
            label3.Size = new Size(57, 31);
            label3.TabIndex = 15;
            label3.Text = "Min";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(494, 358);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(135, 27);
            textBox5.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(421, 352);
            label4.Name = "label4";
            label4.Size = new Size(61, 31);
            label4.TabIndex = 17;
            label4.Text = "Max";
            // 
            // Lab1_Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(Thoat);
            Controls.Add(Xoa);
            Controls.Add(timMinMax);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(soNguyen2);
            Controls.Add(textBox1);
            Controls.Add(soNguyen1);
            Controls.Add(label1);
            Controls.Add(Title);
            Name = "Lab1_Bai2";
            Text = "Lab1_Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label label1;
        private TextBox textBox2;
        private Label soNguyen2;
        private TextBox textBox1;
        private Label soNguyen1;
        private TextBox textBox3;
        private Label label2;
        private Button Thoat;
        private Button Xoa;
        private Button timMinMax;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
    }
}