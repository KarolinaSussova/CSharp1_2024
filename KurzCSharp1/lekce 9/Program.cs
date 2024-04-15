namespace lekce_9
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

   

    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek[] lide = new Clovek[3];
            Clovek clovek1 = new Clovek("Otto", "Novy");
            lide[0] = clovek1;
            lide[1] = new Clovek("Jana", "Vesela");
            lide[2] = new Clovek("Petr", "Kos");

            for (int i = 0; i < lide.Length; i++)
            {
                lide[i].PredstavSe();
            }

        }
    }
}
