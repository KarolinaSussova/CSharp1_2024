namespace lekce_9___break_1
{
    class Clovek
    {
        public string Jmeno;
        public string Prijmeni;

        public Clovek(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public void PredstavSe()
        {
            Console.WriteLine($"{Jmeno} {Prijmeni}");
        }
    }

    class TelefonniKontakt
    {
        public Clovek Clovek;
        public int Cislo;

        public TelefonniKontakt(Clovek clovek, int cislo)
        {
            Clovek = clovek;
            Cislo = cislo;
        }
        public void VypisKontakt()
        {
            Console.WriteLine($"{Clovek.Jmeno} {Clovek.Prijmeni}, {Cislo}");
        }

    }
    class TelefonniSeznam
    {
        public TelefonniKontakt[] ZlateStranky;

        public TelefonniSeznam(TelefonniKontakt vsechnyKontakty)
        {
            ZlateStranky = vsechnyKontakty;
        }

        public void VypisKontaktyZTelefonnihoSeznamu()
        {
            for (int i = 0; i < ZlateStranky.Length; i++)
            {
                ZlateStranky[i].VypisKontakt();
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek1 = new Clovek("Jana", "Chytrá");
            Clovek clovek2 = new Clovek("Tereza", "Pěkná");
            Clovek clovek3 = new Clovek("Katka", "Skvělá");

            Clovek[] lide = new Clovek[4];
            lide[0] = clovek1;
            lide[1] = clovek2;
            lide[2] = clovek3;
            lide[3] = new Clovek("Jiřina", "Nejlepší");


            //     Clovek[] lide = new Clovek[3] {clovek1, clovek2, clovek3};

            for (int i = 0; i < lide.Length; i++)
            {
                Console.WriteLine($"{lide[i].Jmeno} {lide[i].Prijmeni}");
            }

            // telefonní kontakt



            TelefonniKontakt telefonKontakt1 = new TelefonniKontakt(clovek1, 607882113);
            TelefonniKontakt telefonKontakt2 = new TelefonniKontakt(clovek2, 754356789);
            TelefonniKontakt telefonKontakt3 = new TelefonniKontakt(clovek3, 723908765);

            TelefonniKontakt[] mojeKontakty = new TelefonniKontakt[3] { telefonKontakt1, telefonKontakt2, telefonKontakt3 };

            TelefonniSeznam mujSeznam = new TelefonniSeznam(mojeKontakty);



        }
    }
}
