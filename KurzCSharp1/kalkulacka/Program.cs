namespace kalkulacka
{
    class Kalkulacka
    {
        public double AktualniVysledek = 0;
        public double Cislo;
        public string zadanyOperator;


        public bool JePlatnyOperator(string zadanyOperator)
        {
            if ((zadanyOperator == "+") || (zadanyOperator == "-") || (zadanyOperator == "*") || (zadanyOperator == "/") || (zadanyOperator != "^"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Pricti(double Cislo)
        {
            AktualniVysledek = AktualniVysledek + Cislo;
        }

        public void Odecti(double Cislo)
        {
            AktualniVysledek = AktualniVysledek - Cislo;
        }
        public void Vynasob(double Cislo)
        {
            AktualniVysledek = AktualniVysledek * Cislo;
        }

        public void Vydel(double Cislo)
        {
            AktualniVysledek = AktualniVysledek / Cislo;
        }

        public void Umocni(double Cislo)
        {
            double vysledek = 1;

            for (int x = 1; x <= Cislo; x++)
            {
                vysledek = vysledek * AktualniVysledek;
            }

            AktualniVysledek = vysledek;
        }

        public double VratAktualniVysledek()
        {
            return AktualniVysledek;
        }




    }
    internal class Program
    {


        static void Main(string[] args)
        {
            Kalkulacka prvniPocitani = new Kalkulacka();
            double cislo = double.Parse(Console.ReadLine());
            prvniPocitani.Pricti(cislo);


            string zadanyOperator = Console.ReadLine();
            if (prvniPocitani.JePlatnyOperator(zadanyOperator))
            {
                cislo = double.Parse(Console.ReadLine());

                switch (zadanyOperator)
                {
                    case ("+"):
                        prvniPocitani.Pricti(cislo);
                        break;
                    case ("-"):
                        prvniPocitani.Odecti(cislo);
                        break;
                    case ("*"):
                        prvniPocitani.Vynasob(cislo);
                        break;
                    case ("/"):
                        prvniPocitani.Vydel(cislo);
                        break;
                    case ("^"):
                        prvniPocitani.Umocni(cislo);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(prvniPocitani.VratAktualniVysledek());

        }
    }
}
