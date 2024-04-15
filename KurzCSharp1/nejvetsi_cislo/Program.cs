namespace nejvetsi_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej postupně několik celých čísel. Zádáním nuly výběr čísel končí.");
            Console.WriteLine("Zadej celé číslo:");
            int zadaneCislo = int.Parse(Console.ReadLine());

            while (zadaneCislo != 0)
            {
                Console.WriteLine("Zadej další celé číslo:");
                int zadaneCislo2 = int.Parse(Console.ReadLine());
                if ((zadaneCislo2 > zadaneCislo) && (zadaneCislo2 != 0))
                {
                    zadaneCislo = zadaneCislo2;
                }
                else if (zadaneCislo2 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Touto nulou končí vybírání čísel.");
            Console.WriteLine($"Největší zadané číslo je {zadaneCislo}");


        }
    }
}
