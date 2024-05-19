namespace WinFormsApp1
{
    partial class Lab1_Bai5
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
            label1 = new Label();
            textBox1 = new TextBox();
            Print = new Button();
            listMHG = new GroupBox();
            listMH = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtb = new TextBox();
            max = new TextBox();
            pass = new TextBox();
            notpass = new TextBox();
            min = new TextBox();
            rank = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            listMHG.SuspendLayout();
            SuspendLayout();
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Location = new Point(268, 75);
            title1.Name = "title1";
            title1.Size = new Size(297, 31);
            title1.TabIndex = 24;
            title1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(355, 20);
            Title.Name = "Title";
            Title.Size = new Size(106, 46);
            Title.TabIndex = 23;
            Title.Text = "BÀI 5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 125);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 25;
            label1.Text = "Danh sách điểm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(580, 27);
            textBox1.TabIndex = 26;
            // 
            // Print
            // 
            Print.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Print.Location = new Point(521, 173);
            Print.Name = "Print";
            Print.Size = new Size(123, 47);
            Print.TabIndex = 27;
            Print.Text = "XUẤT";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click;
            // 
            // listMHG
            // 
            listMHG.Controls.Add(listMH);
            listMHG.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listMHG.Location = new Point(32, 236);
            listMHG.Name = "listMHG";
            listMHG.Size = new Size(745, 234);
            listMHG.TabIndex = 28;
            listMHG.TabStop = false;
            listMHG.Text = "DANH SÁCH MÔN HỌC VÀ ĐIỂM";
            // 
            // listMH
            // 
            listMH.Location = new Point(18, 40);
            listMH.Multiline = true;
            listMH.Name = "listMH";
            listMH.ReadOnly = true;
            listMH.Size = new Size(711, 176);
            listMH.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 512);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 29;
            label2.Text = "Điểm trung bình";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 560);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 30;
            label3.Text = "Điểm cao nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 608);
            label4.Name = "label4";
            label4.Size = new Size(118, 28);
            label4.TabIndex = 31;
            label4.Text = "Số môn đậu";
            // 
            // dtb
            // 
            dtb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtb.Location = new Point(198, 509);
            dtb.Name = "dtb";
            dtb.ReadOnly = true;
            dtb.Size = new Size(192, 34);
            dtb.TabIndex = 32;
            // 
            // max
            // 
            max.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            max.Location = new Point(198, 554);
            max.Name = "max";
            max.ReadOnly = true;
            max.Size = new Size(192, 34);
            max.TabIndex = 33;
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(198, 602);
            pass.Name = "pass";
            pass.ReadOnly = true;
            pass.Size = new Size(192, 34);
            pass.TabIndex = 34;
            // 
            // notpass
            // 
            notpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notpass.Location = new Point(612, 602);
            notpass.Name = "notpass";
            notpass.ReadOnly = true;
            notpass.Size = new Size(167, 34);
            notpass.TabIndex = 40;
            // 
            // min
            // 
            min.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            min.Location = new Point(612, 554);
            min.Name = "min";
            min.ReadOnly = true;
            min.Size = new Size(167, 34);
            min.TabIndex = 39;
            // 
            // rank
            // 
            rank.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rank.Location = new Point(612, 509);
            rank.Name = "rank";
            rank.ReadOnly = true;
            rank.Size = new Size(167, 34);
            rank.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(427, 608);
            label5.Name = "label5";
            label5.Size = new Size(179, 28);
            label5.TabIndex = 37;
            label5.Text = "Số môn không đậu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(427, 560);
            label6.Name = "label6";
            label6.Size = new Size(147, 28);
            label6.TabIndex = 36;
            label6.Text = "Điểm thấp nhất";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(426, 512);
            label7.Name = "label7";
            label7.Size = new Size(151, 28);
            label7.TabIndex = 35;
            label7.Text = "Xếp loại học lực";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(656, 173);
            button1.Name = "button1";
            button1.Size = new Size(123, 47);
            button1.TabIndex = 41;
            button1.Text = "THOÁT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lab1_Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(845, 682);
            Controls.Add(button1);
            Controls.Add(notpass);
            Controls.Add(min);
            Controls.Add(rank);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pass);
            Controls.Add(max);
            Controls.Add(dtb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listMHG);
            Controls.Add(Print);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(title1);
            Controls.Add(Title);
            Name = "Lab1_Bai5";
            Text = "Lab1_Bai5";
            listMHG.ResumeLayout(false);
            listMHG.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title1;
        private Label Title;
        private Label label1;
        private TextBox textBox1;
        private Button Print;
        private GroupBox listMHG;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dtb;
        private TextBox max;
        private TextBox pass;
        private TextBox notpass;
        private TextBox min;
        private TextBox rank;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox listMH;
        private Button button1;
    }
}