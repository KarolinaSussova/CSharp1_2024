namespace Lekce_5_metody
{
    internal class Program
    {
        public static void Zastekej()
        {
            Console.WriteLine("Haf");
        }

        public static bool PodrbejXKratAZjistiJestliJeSpokojeny(int pocetPodrbani)
        {
            if (pocetPodrbani >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // házéím míčkem, pokud neřeknu jinak, bude to právě třikrát
        public static void HazimMickem (int pocetHodu = 3) //defaultně nastavený parametr, pokud nezadám jinak, bude to tři
        {
            for (int i = 0; i < pocetHodu; i++)
            {
                Console.WriteLine($"Házím mičkem po {i + 1}. ");
            }
            
        }


        static void Main(string[] args)
        {
            bool jeSpokojenyPoJednomPodrbani = PodrbejXKratAZjistiJestliJeSpokojeny(1);
            bool jeSpokojenyPoCtyrechPodrbani = PodrbejXKratAZjistiJestliJeSpokojeny(4);
            HazimMickem(4);
            HazimMickem();
        }
    }
}
