namespace ukol_8
{

    class Kalkulacka
    {
        public double currentResult = 0;
        
        
        public Kalkulacka(double firstNumber)
        {
            currentResult = firstNumber;
        }


        public void Add(double number)
        {
            currentResult = currentResult + number;
        }

        public void Subtract(double number)
        {
            currentResult = currentResult - number;
        }
        public void Multiply(double number)
        {
            currentResult = currentResult * number;
        }

        public void Divide(double number)
        {
            currentResult = currentResult / number;
        }

        public void Power(double number)
        {
            double result = 1;

            for (int x = 1; x <= number; x++)
            {
                result = result * currentResult;
            }

            currentResult = result;
        }

        public double GiveResult()
        {
            return currentResult;
        }
    }
}
