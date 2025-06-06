using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void tinhTong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return; // Nếu không nhập gì
            }

            int num1, num2;
            int sum = 0;

            if (!int.TryParse(textBox1.Text.Trim(), out num1) || !int.TryParse(textBox2.Text.Trim(), out num2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return; // Nếu nó là kí tự khác số
            }
            num1 = int.Parse(textBox1.Text.Trim());
            num2 = int.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
