using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8___break1
{
    class Obdelnik
    {
        public double Delka;
        public double Sirka;
        public static int PocetObdelniku;

        public Obdelnik(double sirkaObdelniku, double delkaObdelniku)
        {
            PocetObdelniku++;

            Delka = delkaObdelniku;
            Sirka = sirkaObdelniku;
        }

        public Obdelnik(double delkaStrany)
        {
            Delka = delkaStrany;
            Sirka = delkaStrany;
        }

        public double VypocitejObsah()
        {
            double obsah = Delka * Sirka;
            return obsah;
        }
    }
}
