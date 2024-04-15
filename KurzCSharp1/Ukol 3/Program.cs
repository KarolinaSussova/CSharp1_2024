namespace Ukol_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dalsiPriklad = true;

            while (dalsiPriklad)
            {
                Console.WriteLine("Zadej první číslo:");
                bool jeCislo1 = double.TryParse(Console.ReadLine(), out double cislo1);

                while (!jeCislo1)
                {
                    Console.WriteLine("Nesprávně zadané číslo. Zadej číslo znovu.");
                    jeCislo1 = double.TryParse(Console.ReadLine(), out cislo1);
                }

                Console.WriteLine("Zadej matematický operátor (+, -, *, /):");
                string zadanyOperator = Console.ReadLine();

                while ((zadanyOperator != "+") && (zadanyOperator != "-") && (zadanyOperator != "*") && (zadanyOperator != "/"))
                {
                    Console.WriteLine("Nesprávně zadaný operátor. Zadej oprátor znovu: ");
                    zadanyOperator = Console.ReadLine();
                }

                Console.WriteLine("Zadej druhé číslo:");
                bool jeCislo2 = double.TryParse(Console.ReadLine(), out double cislo2);

                while (!jeCislo2)
                {
                    Console.WriteLine("Nesprávně zadané číslo. Zadej číslo znovu.");
                    jeCislo2 = double.TryParse(Console.ReadLine(), out cislo2);
                }

                double vysledek = 0;

                switch (zadanyOperator)
                {
                    case ("+"):
                        vysledek = cislo1 + cislo2;
                        break;
                    case ("-"):
                        vysledek = cislo1 - cislo2;
                        break;
                    case ("*"):
                        vysledek = cislo1 * cislo2;
                        break;
                    case ("/"):
                        vysledek = cislo1 / cislo2;
                        break;
                    default:
                        Console.WriteLine("Nesprávně zadaný operátor. Zadej oprátor znovu:");
                        break;
                }

                Console.WriteLine($"Výsledek je: {cislo1} {zadanyOperator} {cislo2} = {vysledek}");
                Console.WriteLine("");
                Console.WriteLine("Přeješ si počítat další příklad? A/N");
                string odpoved = Console.ReadLine();
                bool opakovatOdpoved = true;

                while (opakovatOdpoved)
                {
                    switch (odpoved.ToUpper())
                    {
                        case ("A"):
                            opakovatOdpoved = false;
                            dalsiPriklad = true;
                            break;
                        case ("N"):
                            opakovatOdpoved = false;
                            Console.WriteLine("Ukončuji program");
                            dalsiPriklad = false;
                            break;
                        default:
                            Console.WriteLine("Neplatná odpověď. Přeješ si počítat další příklad? A/N");
                            odpoved = Console.ReadLine();
                            break;
                    }
                }
            }
        }

    }
}

