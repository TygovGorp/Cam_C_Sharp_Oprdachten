namespace Opdracht_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eenProcent = Convert.ToDouble(prijs.Text) / 100;
            double geldKorting = Convert.ToDouble(korting.Text) * eenProcent;
            output.Text = Convert.ToString(Convert.ToDouble(prijs.Text) - geldKorting);
        }
    }
}
