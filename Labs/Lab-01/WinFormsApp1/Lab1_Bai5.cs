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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Print_Click(object sender, EventArgs e)
        {
            listMH.Text = "";
            string input = textBox1.Text;
            string[] stringScore = input.Split(' ');

            double[] scores = new double[stringScore.Length];
            bool validInput = true;

            for (int i = 0; i < stringScore.Length; i++)
            {
                if (double.TryParse(stringScore[i], out double score))
                {
                    scores[i] = score;
                }
                else
                {
                    validInput = false;
                    break;
                }
            }

            if (validInput)
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    listMH.Text += $"Môn {i + 1}: {scores[i]}  ";
                    if ((i + 1) % 3 == 0)
                        listMHG.Text += "\n";
                    //textBox_score.Text += $"Môn {i + 1}: {scores[i]}  ";
                    //if ((i + 1) % 3 == 0)
                    //  textBox_score.Text += "\n";
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }

            //Điểm số trung bình
            dtb.Text = scores.Average().ToString();
            //Điểm số cao nhất
            max.Text = scores.Max().ToString();
            //Điểm số thấp nhất
            min.Text = scores.Min().ToString();
            //Số môn đậu
            pass.Text = scores.Count(score => score >= 5).ToString(); ;
            //Số môn không đậu
            notpass.Text = scores.Count(score => score < 5).ToString();
            //Xếp loại học lực
            double avgScore = scores.Average();
            if (avgScore >= 8 & scores.Count(score => score < 6.5) == 0)
                rank.Text = "Giỏi";
            else if (avgScore >= 6.5 & scores.Count(score => score < 6.5) == 0)
                rank.Text = "Khá";
            else if (avgScore >= 5 & scores.Count(score => score < 3.5) == 0)
                rank.Text = "Trung Bình";
            else if (avgScore >= 3.5 & scores.Count(score => score < 2) == 0)
                rank.Text = "Yếu";
            else rank.Text = "Kém";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
