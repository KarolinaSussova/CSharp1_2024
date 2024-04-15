namespace opakovani_OOP_rytir_a_drak
{
    public class Rytir
    {
        public string Jmeno;
        public int PocetZivotu;
        public double Sila;
        public double Obratnost;
        public bool Brneni;

        public void UtocimNaDraka()
        {
            Console.WriteLine("Útočím na draka");
        }

        public void PredstavSe()
        {
            Console.WriteLine($"Jsem rytíř {Jmeno}, mám počet životů {PocetZivotu}");
        }
    }

    public class Drak
    {
        public string Jmeno;
        public int PocetHlav;
        public double Sila;
        public double Obratnost;
        public bool Brneni;

        public void PredstavSe()
        {
            Console.WriteLine($"Jsem rytíř {Jmeno}, mám počet hlav {PocetHlav}");
        }

        public void ZasazenRytirem()
        {
            /*       for (int i = PocetHlav; i > 1; i--)
                   {
                       PocetHlav = PocetHlav - 1;

                       Console.WriteLine($"Kde mám hlavu! Už mi jich zbývá jen {PocetHlav}");
            }

             */

            /*   while (PocetHlav > 1)
               {
                   PocetHlav = PocetHlav - 1;
                   Console.WriteLine($"Kde mám hlavu! Už mi jich zbývá jen {PocetHlav}");
               }
               Console.WriteLine("Ale nen uťals poslední hlavu. Jsem poražen!");
            */

            PocetHlav = PocetHlav - 1;

            if (PocetHlav >= 1)
            {
                Console.WriteLine($"Kde mám hlavu! Už mi jich zbývá jen {PocetHlav}");
            }
            else
            {
                Console.WriteLine("Ale nen uťals poslední hlavu. Jsem poražen!");
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rytir rytir = new Rytir
            {
                Jmeno = "Jan",
                PocetZivotu = 1,
                Sila = 10,
                Obratnost = 10,
                Brneni = true,
            };

            Drak drak = new Drak
            {
                Jmeno = "Mrak",
                PocetHlav = 5,
                Sila = 8,
                Obratnost = 7,
                Brneni = false,
            };

            rytir.PredstavSe();
            drak.PredstavSe();

            while (drak.PocetHlav > 0)
            {
                rytir.UtocimNaDraka();
                drak.ZasazenRytirem();
            }
           
        }
    }
}
