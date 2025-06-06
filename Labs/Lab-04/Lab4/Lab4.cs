namespace Lab4
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab4_Bai1 bai1 = new Lab4_Bai1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab4_Bai2 bai2 = new Lab4_Bai2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab4_Bai3 bai3 = new Lab4_Bai3();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab4_Bai4 bai4 = new Lab4_Bai4();
            bai4.Show();
        }
    }
}
