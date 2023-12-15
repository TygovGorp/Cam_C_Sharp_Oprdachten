namespace Opdracht_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void number_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tb_input_1 = Convert.ToInt32(number_1.Text);
            int tb_input_2 = Convert.ToInt32(number_2.Text);

            if(tb_input_1 > tb_input_2) label1.Text = Convert.ToString(tb_input_1);
            else label1.Text = Convert.ToString(tb_input_2);
            label1.Text = tb_input_1 > tb_input_2 ?  Convert.ToString(tb_input_1) : Convert.ToString(tb_input_1);
        }
    }
}
