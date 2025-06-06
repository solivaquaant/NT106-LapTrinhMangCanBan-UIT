namespace Lab5
{
    partial class Dashboard
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
            buttonBai1 = new Button();
            buttonBai4 = new Button();
            buttonBai3 = new Button();
            buttonBai2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonBai1
            // 
            buttonBai1.Font = new Font("Segoe UI", 15F);
            buttonBai1.Location = new Point(136, 133);
            buttonBai1.Name = "buttonBai1";
            buttonBai1.Size = new Size(154, 57);
            buttonBai1.TabIndex = 0;
            buttonBai1.Text = "Bài 1";
            buttonBai1.UseVisualStyleBackColor = true;
            buttonBai1.Click += buttonBai1_Click;
            // 
            // buttonBai4
            // 
            buttonBai4.Font = new Font("Segoe UI", 15F);
            buttonBai4.Location = new Point(467, 278);
            buttonBai4.Name = "buttonBai4";
            buttonBai4.Size = new Size(154, 57);
            buttonBai4.TabIndex = 1;
            buttonBai4.Text = "Bài 4";
            buttonBai4.UseVisualStyleBackColor = true;
            buttonBai4.Click += buttonBai4_Click;
            // 
            // buttonBai3
            // 
            buttonBai3.Font = new Font("Segoe UI", 15F);
            buttonBai3.Location = new Point(136, 278);
            buttonBai3.Name = "buttonBai3";
            buttonBai3.Size = new Size(154, 57);
            buttonBai3.TabIndex = 2;
            buttonBai3.Text = "Bài 3";
            buttonBai3.UseVisualStyleBackColor = true;
            buttonBai3.Click += buttonBai3_Click;
            // 
            // buttonBai2
            // 
            buttonBai2.Font = new Font("Segoe UI", 15F);
            buttonBai2.Location = new Point(467, 133);
            buttonBai2.Name = "buttonBai2";
            buttonBai2.Size = new Size(154, 57);
            buttonBai2.TabIndex = 3;
            buttonBai2.Text = "Bài 2";
            buttonBai2.UseVisualStyleBackColor = true;
            buttonBai2.Click += buttonBai2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(332, 54);
            label1.Name = "label1";
            label1.Size = new Size(78, 35);
            label1.TabIndex = 4;
            label1.Text = "LAB 5";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonBai2);
            Controls.Add(buttonBai3);
            Controls.Add(buttonBai4);
            Controls.Add(buttonBai1);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBai1;
        private Button buttonBai4;
        private Button buttonBai3;
        private Button buttonBai2;
        private Label label1;
    }
}
