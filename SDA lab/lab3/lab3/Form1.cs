namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Abdul Quddos" && textBox2.Text == "abdul542001")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}