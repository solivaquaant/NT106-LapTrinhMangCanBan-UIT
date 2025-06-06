using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string BasicNumber(int num)
        {
            switch (num)
            {
                case 1:
                    return "một ";
                    break;
                case 2:
                    return "hai ";
                    break;
                case 3:
                    return "ba ";
                    break;
                case 4:
                    return "bốn ";
                    break;
                case 5:
                    return "năm ";
                    break;
                case 6:
                    return "sáu ";
                    break;
                case 7:
                    return "bảy ";
                    break;
                case 8:
                    return "tám ";
                    break;
                case 9:
                    return "chín ";
                    break;
                default:
                    return null;
            }
        }

        private string ConvertToText(int num)
        {
            string result = "";
            int thousands = num / 1000;
            int hundreds = (num % 1000) / 100;
            int tens = (num % 100) / 10;
            int units = num % 10;

            if (num == 0)
            {
                result += "không";
            }

            if (thousands > 0)
            {
                result = BasicNumber(thousands) + "nghìn ";
            }

            if (hundreds > 0)
            {
                result += BasicNumber(hundreds) + "trăm ";
            }
            else if (thousands > 0 & hundreds == 0 & (tens > 0))
            {
                result += "không trăm ";
            }

            if (tens > 0)
            {
                if (tens == 1) result += "mười ";
                else result += BasicNumber(tens) + "mươi ";
            }
            else if ((tens == 0) & (thousands > 0 | hundreds > 0) & (units > 0))
            {
                result += "linh ";
            }

            if (units > 0)
            {
                if (tens > 0)
                {
                    switch (units)
                    {
                        case 1:
                            if (tens > 1) result += "mốt ";
                            else if (tens == 1) result += "một ";
                            break;
                        case 5:
                            result += "lăm ";
                            break;
                        default:
                            result += BasicNumber(units);
                            break;
                    }
                }
                else
                {
                    result += BasicNumber(units);
                }
            }
            return result;
        }

        private void ReadNum_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Vui lòng không để trống!");
                    return;
                }
                int num;

                if (!int.TryParse(textBox1.Text.Trim(), out num))
                {
                    MessageBox.Show("Vui lòng nhập hợp lệ");
                    return;
                }
                num = Int32.Parse(textBox1.Text.Trim());
                if (num < 0 || num > 9999)
                {
                    MessageBox.Show("Vui lòng nhập hợp lệ");
                    return;
                }

                string res = ConvertToText(num);
                textBox2.Text = res;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số phù hợp!");
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




