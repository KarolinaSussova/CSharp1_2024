using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8
{
    class Rytir
    {
        public string Jmeno;
        public int PocetZivotu;
        public double Sila;
        public static int PocetRytiru; //static - sdílená statická promenná pro všechny objekty

        public Rytir(string jmenoRytire, int pocetZivotuRytire, double silaRytire)
        {
            PocetRytiru++;

            Jmeno = jmenoRytire;
            if (pocetZivotuRytire <= 0)
            {
                PocetZivotu = 1;
            }
            else
            {
                PocetZivotu = pocetZivotuRytire;
            }
            Sila = silaRytire;
        }

        public Rytir (string jmenoRytire) // druhý konstruktor objektu, při vytváření si budu moct vybrat, který použiju
        {
            Jmeno = jmenoRytire;
            PocetZivotu = 3;
            Sila = 100;
        }

        public void UtocimNaDraka()
        {
            Console.WriteLine("Útočím na draka!");
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Jsem rytíř a jmenuju se {Jmeno}, mám {PocetZivotu} životů, a moje síle je {Sila}.");
        }

    }
}
