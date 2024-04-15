using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce8
{
    class Drak
    {
        public string Jmeno;
        public int PocetHlav;
        public double Sila;

        public void PredstavSe()
        {
            Console.WriteLine($"Jsem drak a jmenuju se {Jmeno}, mám {PocetHlav} hlav, a moje síle je {Sila}.");
        }

        public void ZasazeniRitirem()
        {
            PocetHlav--;
            if (PocetHlav > 0)
            {
                Console.WriteLine($"Prišel jsem o hlavu. Zbývá mi jich {PocetHlav}");
            }
            else
            {
                Console.WriteLine("Jsem poražen...");
            }
        }

    }
}
