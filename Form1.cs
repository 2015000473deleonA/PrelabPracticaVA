namespace PRELABORATORIO_I___PRACTICA_SUPERVISADA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";
        }
        CRUD cambio1 = new CRUD();

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                this.Hide();
                cambio1.Show();
            }
        }
    }
}
