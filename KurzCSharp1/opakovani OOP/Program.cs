namespace opakovani_OOP
{
    class Clovek
    {
        public string Jmeno;
        public string Pohlavi;
        public int RokNarozeni;
        public double Hmotnost;
        public bool VManzelstvi;


        public Clovek(string jmeno, string pohlavi, int rokNarozeni, double hmotnost, bool manzelstvi)
        {
            Jmeno = jmeno;
            Pohlavi = pohlavi;
            RokNarozeni = rokNarozeni;
            Hmotnost = hmotnost;
            VManzelstvi = manzelstvi;
        }

        public void VypisUdajeOCloveku()
        {
            Console.WriteLine($"Jméno tohoto člověka je {Jmeno}, jeho pohlaví je {Pohlavi} a jeho věk je {VypocitejVek()} let a je {VratStavVManzelstvi()}");
        }

        public int VypocitejVek()
        {
            int Vek = 2024 - RokNarozeni;
            return Vek;
        }

        public string VratStavVManzelstvi()
        {
            string stavVManzelstvi = "";

            if (VManzelstvi)
            {
                switch (Pohlavi)
                {
                    case "žena":
                        stavVManzelstvi = "vdaná";
                        break;
                    case "muž":
                        stavVManzelstvi = "ženatý";
                        break;
                }
            }
            else
            {
                switch (Pohlavi)
                {
                    case "žena":
                        stavVManzelstvi = "svobodná";
                        break;
                    case "muž":
                        stavVManzelstvi = "svobodný";
                        break;
                }
            }
            return stavVManzelstvi;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*       Clovek clovek1 = new Clovek
                   {
                       Jmeno = "Jitka",
                       Pohlavi = "žena",
                       Vek = 33,
                       Hmotnost = 65.5,
                       VManzelstvi = true
                   };

                   Clovek clovek2 = new Clovek
                   {
                       Jmeno = "Pavel",
                       Pohlavi = "muž",
                       Vek = 39,
                       Hmotnost = 87,
                       VManzelstvi = true,
                   };

                   Clovek clovek3 = new Clovek();
                   clovek3.Jmeno = "Dan";
                   clovek3.Pohlavi = "muž";
                   clovek3.Vek = 47;
                   clovek3.Hmotnost = 98;
                   clovek3.VManzelstvi = false;
            */

            Clovek clovek1 = new Clovek("Jitka", "žena", 1990, 76, true);

            clovek1.VypisUdajeOCloveku();

        }
    }
}
