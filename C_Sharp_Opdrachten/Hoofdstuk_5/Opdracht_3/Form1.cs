namespace Opdracht_3
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

        private void button1_Click(object sender, EventArgs e)
        {
            int tb_input = Convert.ToInt32(textBox1.Text);

            switch (tb_input)
            {
                case 1:
                    label1.Text = "maandag";
                    break;
                case 2:
                    label1.Text = "dinsdag";
                    break;
                case 3:
                    label1.Text = "woensdag";
                    break;
                case 4:
                    label1.Text = "donderdag";
                    break;
                case 5:
                    label1.Text = "vrijdag";
                    break;
                case 6:
                    label1.Text = "zaterdag";
                    break;
                case 7:
                    label1.Text = "zondag";
                    break;
                default:
                    break;
            }
        }
    }
}
