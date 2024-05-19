namespace Lab3_Server
{
    public partial class Lab3_S : Form
    {
        public Lab3_S()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab3_Bai1_S bai1 = new Lab3_Bai1_S();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab3_Bai2_S bai2 = new Lab3_Bai2_S();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab3_Bai3_S bai3 = new Lab3_Bai3_S();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab3_Bai4_S bai4 = new Lab3_Bai4_S();
            bai4.Show();
        }
    }
}
