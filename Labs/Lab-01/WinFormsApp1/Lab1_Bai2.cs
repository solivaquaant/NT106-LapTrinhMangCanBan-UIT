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
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void timMinMax_Click(object sender, EventArgs e)
        {
            double num1, num2, num3;

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
                return; // Nếu không nhập gì
            }

            num1 = double.Parse(textBox1.Text.Trim());
            num2 = double.Parse(textBox2.Text.Trim());
            num3 = double.Parse(textBox3.Text.Trim());

            double min1 = num1;
            double max1 = num1;

            if (!double.TryParse(textBox1.Text.Trim(), out num1) || !double.TryParse(textBox2.Text.Trim(), out num2) || !double.TryParse(textBox3.Text.Trim(), out num3))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return; // Nếu nó là kí tự khác số
            }

            // So sánh num2 với max1 để cập nhật max1
            if (num2 > max1)
            {
                max1 = num2;
            }

            // So sánh num3 với max1 để cập nhật max1
            if (num3 > max1)
            {
                max1 = num3;
            }

            // So sánh num2 với min1 để cập nhật min1
            if (num2 < min1)
            {
                min1 = num2;
            }

            // So sánh num3 với min1 để cập nhật min1
            if (num3 < min1)
            {
                min1 = num3;
            }

            textBox4.Text = min1.ToString();
            textBox5.Text = max1.ToString();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
