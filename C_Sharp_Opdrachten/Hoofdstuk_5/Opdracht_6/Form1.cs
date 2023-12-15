namespace Opdracht_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb_input_1 = textBox1.Text;
            string tb_input_2 = textBox2.Text;
            textBox1.Text = tb_input_2;
            textBox2.Text = tb_input_1;
        }
    }
}
