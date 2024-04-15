namespace Lekce9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vytvoř libovolné 3 instance třídy TelefonniKontakt.
            TelefonniKontakt kontaktNaPeta = new TelefonniKontakt(new Clovek("Petr", "Novák"), "123 456 789");
            TelefonniKontakt kontaktNaJanu = new TelefonniKontakt(new Clovek("Jana", "Nováková"), "987 654 321");
            TelefonniKontakt kontaktNaKarla = new TelefonniKontakt(new Clovek("Karel", "Vomáčka"), "456 789 123");

            // 2. Vytvoř pole telefonních kontaktů (o velikosti 3),
            //    do kterého přiřaď všechny telefonní kontakty z předhozího bodu.
            TelefonniKontakt[] mojeKontakty = new TelefonniKontakt[3] { kontaktNaPeta, kontaktNaJanu, kontaktNaKarla };
            Console.WriteLine(mojeKontakty.Length);
            Console.WriteLine("Vypis moje kontakty:");
            for (int a = 0; a < mojeKontakty.Length; a++)
            {
                mojeKontakty[a].Vypis();
            }

            // 4. Vytvoř instanci třídy TelefonniSeznam a přiřaď jeho vlastnosti
            //    pole telefonních kontaktů vytvořené v kroku 2.
            TelefonniSeznam mojSeznam = new TelefonniSeznam(mojeKontakty);
            mojeKontakty[2] = new TelefonniKontakt(new Clovek("Pavol", "Novák"), "123 456 789");

            // 5. Třídě TelefonniSeznam přidej metodu VypisKontakty(),
            //    která pomocí FOR cyklu vypíše do konzole informace
            //    o všech kontaktech v telefonním seznamu
            Console.WriteLine("Vypis kontakty zo Zlatych Stranok:");
            mojSeznam.VypisKontakty();
        }


        //Priprava: 
        // třída Clovek (vlastnosti Jmeno a Prijmeni, metoda PredstavSe)
        public class Clovek
        {
            public string Jmeno;
            public string Prijmeni;

            public Clovek(string jmeno, string prijmeni)
            {
                Jmeno = jmeno;
                Prijmeni = prijmeni;
            }
        }


        //Priprava: 
        // třída TelefonniKontakt (vlastnosti Clovek a Cislo, metoda Vypis)
        public class TelefonniKontakt
        {
            public Clovek Clovek;
            public string Cislo;

            public TelefonniKontakt(Clovek clovek, string cislo)
            {
                Clovek = clovek;
                Cislo = cislo;
            }

            public void Vypis()
            {
                Console.WriteLine($"{Clovek.Jmeno} {Clovek.Prijmeni} - {Cislo}");
            }
        }


        // 3. Vytvoř třídu TelefonniSeznam, která bude mít vlastní pole,
        //    do které se dá uložit pole telefonních kontaktů.
        public class TelefonniSeznam
        {
            public TelefonniKontakt[] ZlateStranky;

            // 6. BONUS: Vytvoř třídě TelefonniSeznam konstruktor, 
            //    jehož parametrem bude pole telefonních kontaktů a ty si v konstruktoru ulož do vlastnosti.
            //    Změň modifikátor přístupu vlastnosti, která obsahuje pole telefonních kontaktů
            //    na private, tak, aby jej nemohl nikdo "zvenku" přepsat. 
            //    Uprav vytváření instance třídy TelefonniSeznam, aby používal tento nový konstruktor.
            public TelefonniSeznam(TelefonniKontakt[] mojeKontakty)
            {
                ZlateStranky = new TelefonniKontakt[mojeKontakty.Length];
                //ZlateStranky = mojeKontakty;
                for (int i = 0; i < mojeKontakty.Length; i++)
                {
                    ZlateStranky[i] = new TelefonniKontakt(mojeKontakty[i].Clovek, mojeKontakty[i].Cislo);
                }
            }

            public void VypisKontakty()
            {
                for (int i = 0; i < ZlateStranky.Length; i++)
                {
                    ZlateStranky[i].Vypis();
                }
            }
        }
    }
}