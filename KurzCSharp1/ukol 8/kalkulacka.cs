namespace ukol_8
{

    class Kalkulacka
    {
        public double AktualniVysledek = 0;
        public double Cislo;
        public string zadanyOperator;


        public bool JePlatnyOperator(string zadanyOperator)
        {
            if ((zadanyOperator == "+") || (zadanyOperator == "-") || (zadanyOperator == "*") || (zadanyOperator == "/") || (zadanyOperator == "^"))
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
}
