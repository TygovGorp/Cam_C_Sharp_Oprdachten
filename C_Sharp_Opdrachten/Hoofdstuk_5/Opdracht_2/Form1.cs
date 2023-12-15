namespace Opdracht_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tb_input_1 = Convert.ToInt32(textBox1.Text);
            int tb_input_2 = Convert.ToInt32(textBox2.Text);
            int tb_input_3 = Convert.ToInt32(textBox3.Text);

            if (tb_input_1 < tb_input_2 && tb_input_1 < tb_input_3) label1.Text = Convert.ToString(tb_input_1);
            else if (tb_input_2 < tb_input_3) label1.Text = Convert.ToString(tb_input_2);
            else label1.Text = Convert.ToString(tb_input_3);
        }
    }
}
