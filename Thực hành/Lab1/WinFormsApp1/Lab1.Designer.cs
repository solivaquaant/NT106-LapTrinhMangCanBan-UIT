namespace WinFormsApp1
{
    partial class Lab1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            Bai1 = new Button();
            Bai2 = new Button();
            Bai3 = new Button();
            Bai4 = new Button();
            Bai5 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(114, 75);
            Title.Name = "Title";
            Title.Size = new Size(132, 54);
            Title.TabIndex = 0;
            Title.Text = "LAB 1";
            Title.Click += Title_Click;
            // 
            // Bai1
            // 
            Bai1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bai1.Location = new Point(114, 156);
            Bai1.Name = "Bai1";
            Bai1.Size = new Size(176, 62);
            Bai1.TabIndex = 1;
            Bai1.Text = "BÀI 1";
            Bai1.UseVisualStyleBackColor = true;
            Bai1.Click += Bai1_Click;
            // 
            // Bai2
            // 
            Bai2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bai2.Location = new Point(309, 156);
            Bai2.Name = "Bai2";
            Bai2.Size = new Size(176, 62);
            Bai2.TabIndex = 2;
            Bai2.Text = "BÀI 2";
            Bai2.UseVisualStyleBackColor = true;
            Bai2.Click += Bai2_Click;
            // 
            // Bai3
            // 
            Bai3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bai3.Location = new Point(505, 156);
            Bai3.Name = "Bai3";
            Bai3.Size = new Size(176, 62);
            Bai3.TabIndex = 3;
            Bai3.Text = "BÀI 3";
            Bai3.UseVisualStyleBackColor = true;
            Bai3.Click += Bai3_Click_1;
            // 
            // Bai4
            // 
            Bai4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bai4.Location = new Point(114, 234);
            Bai4.Name = "Bai4";
            Bai4.Size = new Size(176, 62);
            Bai4.TabIndex = 4;
            Bai4.Text = "BÀI 4";
            Bai4.UseVisualStyleBackColor = true;
            Bai4.Click += Bai4_Click;
            // 
            // Bai5
            // 
            Bai5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bai5.Location = new Point(309, 234);
            Bai5.Name = "Bai5";
            Bai5.Size = new Size(176, 62);
            Bai5.TabIndex = 5;
            Bai5.Text = "BÀI 5";
            Bai5.UseVisualStyleBackColor = true;
            Bai5.Click += Bai5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(505, 234);
            button1.Name = "button1";
            button1.Size = new Size(176, 62);
            button1.TabIndex = 6;
            button1.Text = "THOÁT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lab1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Bai5);
            Controls.Add(Bai4);
            Controls.Add(Bai3);
            Controls.Add(Bai2);
            Controls.Add(Bai1);
            Controls.Add(Title);
            Name = "Lab1";
            Text = "Lab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button Bai1;
        private Button Bai2;
        private Button Bai3;
        private Button Bai4;
        private Button Bai5;
        private Button button1;
    }
}
