using ukol_8;

namespace graficka_kalkulacka
{
    public partial class Form1 : Form
    {
        private Kalkulacka kalkulacka;
        private string sign;
        private bool isFirstEntryNumber = true;
        private bool firstEntry = true;
        private bool numberAfterResult = false;


        public Form1()
        {
            kalkulacka = new Kalkulacka(0);
            InitializeComponent();
        }

        private void NumberButton(object sender, EventArgs e)
        {
            if (isFirstEntryNumber)
            {
                text.Text = string.Empty;
                isFirstEntryNumber = false;
            }

            if (numberAfterResult)
            {
                text.Text = string.Empty;
                isFirstEntryNumber = false;
                kalkulacka.currentResult = 0;
                firstEntry = true;
            }

            Button btn = (Button)sender;
            text.Text += btn.Text;
        }

        private void SignButton(object sender, EventArgs e)
        {
            if (firstEntry)
            {
                kalkulacka.Add(double.Parse(text.Text));
                firstEntry = false;
            }
            Button btn = (Button)sender;
            sign = btn.Text;

            label1.Text = text.Text;
            label1.Text += btn.Text;

            isFirstEntryNumber = true;
            numberAfterResult = false;
        }

        private void EvaluateButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            double Number = double.Parse(text.Text);
            switch (sign)
            {
                case "+":
                    kalkulacka.Add(Number);
                    break;
                case "-":
                    kalkulacka.Subtract(Number);
                    break;
                case "*":
                    kalkulacka.Multiply(Number);
                    break;
                case "/":
                    kalkulacka.Divide(Number);
                    break;
            }

            label1.Text += text.Text;
            label1.Text += btn.Text;
            text.Text = kalkulacka.GiveResult().ToString();
            numberAfterResult = true;

        }

        
    }
}
