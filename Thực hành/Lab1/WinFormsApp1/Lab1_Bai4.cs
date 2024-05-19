using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }
        private int getBase(string str)
        {
           
            switch (str)
            {
                case "Binary":
                    return 2;
                case "Decimal":
                    return 10;
                case "Hexadecimal":
                    return 16;
                default: return 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;

            // Kiểm tra xem người dùng đã nhập số hay không
            if (!string.IsNullOrEmpty(num))
            {
                // Chuyển đổi sang cơ số 10
                int fromBase = getBase(comboBox1.Text);
                int temp;
                try
                {
                    temp = Convert.ToInt32(num, fromBase);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!");
                    return;
                }

                // Chuyển đổi sang cơ số yêu cầu
                int toBase = getBase(comboBox2.Text);

                textBox2.Text = Convert.ToString(temp, toBase);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số!");
            }


        }


        private void Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

