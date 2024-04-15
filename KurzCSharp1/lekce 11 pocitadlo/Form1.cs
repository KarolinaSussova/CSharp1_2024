namespace lekce_11_pocitadlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tlacitkoVlevo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            double aktualniPocetKliku = double.Parse(label1.Text);
            aktualniPocetKliku += 1;
            label1.Text = aktualniPocetKliku.ToString();

        }

    }
}
