namespace Opdracht_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            output.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            output.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            output.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            output.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
        }
    }
}
