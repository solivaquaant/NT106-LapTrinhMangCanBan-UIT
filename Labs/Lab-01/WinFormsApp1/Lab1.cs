namespace WinFormsApp1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Bai3_Click(object sender, EventArgs e)
        {

        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Lab1_Bai1 lab1 = new Lab1_Bai1();
            lab1.Show();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Lab1_Bai2 lab2 = new Lab1_Bai2();
            lab2.Show();
        }

        private void Bai3_Click_1(object sender, EventArgs e)
        {
            Lab1_Bai3 lab3 = new Lab1_Bai3();
            lab3.Show();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 lab4 = new Lab1_Bai4();
            lab4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 lab1_Bai5 = new Lab1_Bai5();
            lab1_Bai5.Show();
        }
    }
}
