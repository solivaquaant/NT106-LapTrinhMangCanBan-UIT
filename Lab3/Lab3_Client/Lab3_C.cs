namespace Lab3_Client
{
    public partial class Lab3_C : Form
    {
        public Lab3_C()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab3_Bai1_C bai1 = new Lab3_Bai1_C();
            bai1.Show();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            Lab3_Bai3_C bai3 = new Lab3_Bai3_C();
            bai3.Show();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            Lab3_Bai4_C bai4 = new Lab3_Bai4_C();
            bai4.Show();
        }
    }
}