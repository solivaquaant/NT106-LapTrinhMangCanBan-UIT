﻿namespace Lab3_Server
{
    partial class Lab3_Bai2_S
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
            Listen = new Button();
            label4 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // Listen
            // 
            Listen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Listen.Location = new Point(597, 79);
            Listen.Name = "Listen";
            Listen.Size = new Size(162, 37);
            Listen.TabIndex = 19;
            Listen.Text = "LISTEN";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 79);
            label4.Name = "label4";
            label4.Size = new Size(188, 31);
            label4.TabIndex = 18;
            label4.Text = "Receive Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 17;
            label1.Text = "BÀI 2";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(55, 133);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(702, 274);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // Lab3_Bai2_S
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(Listen);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Lab3_Bai2_S";
            Text = "Lab3_Bai2_S";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Listen;
        private Label label4;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}