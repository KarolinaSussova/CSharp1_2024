namespace lekce_12
{
    public partial class Form1 : Form
    {
        private bool bylUcastnikSpokojen = false;
        private string oblibenySemestr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // pøetypování
            bool bylUcastnikSpokojen = checkBox.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelOdpoved.Text = $"Byl/a ráda: {bylUcastnikSpokojen} a oblíbený semestr je {oblibenySemestr}.";
        }

        private void volbaSemestru(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string oblibenySemestr = radioButton.Text;

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
