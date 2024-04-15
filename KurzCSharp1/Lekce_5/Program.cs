namespace Lekce_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int odpracovaneHodiny = 0;
            int nutnychOdpracovanychHodin = 8;

            while (odpracovaneHodiny < nutnychOdpracovanychHodin)
            {
                // Pracuju
                odpracovaneHodiny++;
                Console.WriteLine($"Pracuju hodinu a už mám odpracováno {odpracovaneHodiny} hodin/y");
                // násobek 4 - něco vypíšu
                if (odpracovaneHodiny % 4 == 0)
                {
                    Console.WriteLine("Začínám mít hlad");
                }
                if (odpracovaneHodiny % 6 == 0)
                {
                    Console.WriteLine("Dej si pauzu 30min.");
                }
            }
            Console.WriteLine($"Mám padla");


            int pocetVajecVBaleni = 10;
            int startovniPocetVajec = 3;
            
            for (int aktualniVejce = startovniPocetVajec + 1; aktualniVejce <= pocetVajecVBaleni; aktualniVejce++)
            {
                Console.WriteLine($"Přidávám vejce. V balení bude {aktualniVejce} z {pocetVajecVBaleni} vajec.");
            }
            Console.WriteLine("Balení doplněno");
        }
    }
}
