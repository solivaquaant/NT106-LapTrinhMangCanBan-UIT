using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai3 : Form
    {
        public Lab2_Bai3()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            richTextBox_result.Clear();
        }
        static double CalculateExpression(string expression)
        {
            // Hàm tính toán biểu thức
            DataTable dt = new DataTable();
            return Convert.ToDouble(dt.Compute(expression, ""));
        }
        private void ReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                richTextBox_result.Text = sr.ReadToEnd();

                fs.Close();
            }
            catch
            {
                MessageBox.Show("Có phép tính nhập vào không đúng!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ richTextBox
                string[] expressions = richTextBox_result.Text.Split('\n');

                // Mở tệp tin đầu ra
                SaveFileDialog sfdOutput = new SaveFileDialog();
                sfdOutput.ShowDialog();
                FileStream fsOutput = new FileStream(sfdOutput.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fsOutput);

                // Xóa nội dung của richTextBox
                richTextBox_result.Clear();

                // Tính toán và ghi kết quả vào richTextBox và tệp tin đầu ra
                foreach (string expression in expressions)
                {
                    if (!string.IsNullOrWhiteSpace(expression))
                    {
                        var result = CalculateExpression(expression);
                        richTextBox_result.Text += expression + " = " + result.ToString() + "\n";
                        sw.WriteLine(expression + " = " + result.ToString());
                    }
                }

                // Đóng tệp tin đầu ra
                sw.Close();
                fsOutput.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Có phép tính nhập vào không đúng!");
            }

        }

        private void Lab2_Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
