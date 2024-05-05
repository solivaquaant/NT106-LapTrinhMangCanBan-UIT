
namespace TCP_chat_server
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_listen = new System.Windows.Forms.Button();
            this.richTextBox_rmsg = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(40, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(163, 95);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(288, 22);
            this.textBox_port.TabIndex = 1;
            // 
            // button_listen
            // 
            this.button_listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_listen.Location = new System.Drawing.Point(550, 88);
            this.button_listen.Name = "button_listen";
            this.button_listen.Size = new System.Drawing.Size(122, 37);
            this.button_listen.TabIndex = 2;
            this.button_listen.Text = "Listen";
            this.button_listen.UseVisualStyleBackColor = true;
            this.button_listen.Click += new System.EventHandler(this.button_listen_Click);
            // 
            // richTextBox_rmsg
            // 
            this.richTextBox_rmsg.Location = new System.Drawing.Point(45, 225);
            this.richTextBox_rmsg.Name = "richTextBox_rmsg";
            this.richTextBox_rmsg.ReadOnly = true;
            this.richTextBox_rmsg.Size = new System.Drawing.Size(675, 128);
            this.richTextBox_rmsg.TabIndex = 3;
            this.richTextBox_rmsg.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(40, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_rmsg);
            this.Controls.Add(this.button_listen);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_listen;
        private System.Windows.Forms.RichTextBox richTextBox_rmsg;
        private System.Windows.Forms.Label label2;
    }
}

