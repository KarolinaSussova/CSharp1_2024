namespace ukol_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Zadej číslo:");
                bool jeCislo1 = double.TryParse(Console.ReadLine(), out double cislo1);

                while (!jeCislo1)
                {
                    Console.WriteLine("Nesprávně zadané číslo, prosím zadej znovu:");
                    jeCislo1 = double.TryParse(Console.ReadLine(), out cislo1);
                }

                Console.WriteLine("Zadej matematický operátor (+, - , *, /, ^) :");
                string zadanyOperator = Console.ReadLine();

                while ((zadanyOperator != "+") && (zadanyOperator != "-") && (zadanyOperator != "*") && (zadanyOperator != "/") && (zadanyOperator != "^"))
                {
                    Console.WriteLine("Nesprávně zadaný operátor, prosím zadej znovu:");
                    zadanyOperator = Console.ReadLine();
                }

                Console.WriteLine("Zadej číslo:");
                bool jeCislo2 = double.TryParse(Console.ReadLine(), out double cislo2);

                while (!jeCislo2)
                {
                    Console.WriteLine("Nesprávně zadané číslo, prosím zadej znovu:");
                    jeCislo2 = double.TryParse(Console.ReadLine(), out cislo2);
                }

                double vysledek = 1;
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
                    case ("^"):
                        for (int x = 1; x <= cislo2; x++)
                        {
                            vysledek = vysledek * cislo1;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Výsledek {cislo1} {zadanyOperator} {cislo2} = {vysledek}");
                Console.WriteLine();
            }
        }
    }
}

