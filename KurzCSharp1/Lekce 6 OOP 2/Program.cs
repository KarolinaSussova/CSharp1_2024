namespace Lekce_6_OOP_2
{
    public class Auto
    {
        public string Vyrobce;
        public int PocetSedacek;
        public int RokVyroby;
        public string Barva;


        public void VypisVlastnosti()
        {
            Console.WriteLine($"Výrobce je {Vyrobce}, počet sedaček je {PocetSedacek}, rok výroby je {RokVyroby}, barva {Barva}. Stáří auta je {VratStariAuta()}.");
        }

        public int VratStariAuta()
        {
            int stariAuta = 2024 - RokVyroby;
            return stariAuta;
        }
    }

    public class Clovek
    {
        public string Jmeno;
        public string Pohlavi;
        public int RokNarozeni;
        public double Hmotnost;
        public bool VManzelstvi;
        public string Mesto = "Praha";
        string stav;

        public void VypisInformace()

        {
            
            if ((VManzelstvi = true) && Pohlavi == "žena")
            {
                stav = "vdaná";
            }
            else if ((VManzelstvi = false) && Pohlavi == "žena")
            {
                stav = "není vdaná";
                }
            if ( Pohlavi == "muž" && (VManzelstvi = true))
            {
                stav = "ženatý";
            }
            else if ( Pohlavi == "muž" && (VManzelstvi = false))
            {
                stav = "není ženatý";
            }

            Console.WriteLine($"Jméno {Jmeno}, pohlaví {Pohlavi}, rok narození {RokNarozeni}, {stav}, město {Mesto}, věk {VratVek()}");
        }



        public int VratVek()
        {
            int vek = 2024 - RokNarozeni;
            return vek;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.Vyrobce = "Ferrari";
            ferrari.PocetSedacek = 4;
            ferrari.RokVyroby = 1999;
            ferrari.Barva = "Červená";

            ferrari.VypisVlastnosti();


            // Breakout Room 1
            // vytvorte tridu Clovek, ktera bude mit vlastnosti jmeno (string), pohlavi (string), rok narozeni (int), 
            // hmotnost (double), v manzelstvi (bool)
            // vytvor dve instance a napln je daty
            // vypis informace na konzoli (zatim jen s pouzitim Console.WriteLine v Main)

            // Breakout Room 2 - Rozsirime tridu Clovek z 1. Breakout Roomu
            // napiste metodu VypisInformace, ktera vypise vsechny vlastnosti
            // v metode VypisInformace napiste "zenaty" nebo "vdana" (nikoliv true nebo false) podle hodnoty vlastnosti "pohlavi"
            // Vytvor metodu VratVek, ktera podle roku narozeni vypocita a vrati aktualni vek. Ten vypis na konzoli.

            Clovek clovek1 = new Clovek();

            clovek1.Jmeno = "Jana";
            clovek1.Pohlavi = "žena";
            clovek1.RokNarozeni = 1960;
            clovek1.Hmotnost = 75;
            clovek1.VManzelstvi = true;



            Clovek clovek2 = new Clovek
            {
                Jmeno = "Petr",
                Pohlavi = "muž",
                RokNarozeni = 1960,
                Hmotnost = 125,
                VManzelstvi = false
            };

            Console.WriteLine($"Člověk 1: {clovek1.Jmeno}, {clovek1.Pohlavi}, {clovek1.RokNarozeni}, {clovek1.Hmotnost}, {clovek1.VManzelstvi}, {clovek1.Mesto}");

            clovek1.VypisInformace();
            clovek2.VypisInformace();
        }

    }
}
