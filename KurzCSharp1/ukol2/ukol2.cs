namespace ukol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první číslo:");
            bool jeCislo1 = double.TryParse(Console.ReadLine(), out double cislo1);
            if (jeCislo1)
            {
                Console.WriteLine("Zadej matematický operátor (+, - , *, /): ");
                string zadanyOperator = Console.ReadLine();
                if ((zadanyOperator == "+") || (zadanyOperator == "-") || (zadanyOperator == "*") || (zadanyOperator == "/"))
                {
                    Console.WriteLine("Zadej druhé číslo: ");
                    bool jeCislo2 = double.TryParse(Console.ReadLine(), out double cislo2);
                    double vysledek = 0;
                    if (jeCislo2)
                    {
                        if (zadanyOperator == "+")
                        {
                            vysledek = cislo1 + cislo2;
                        }
                        else if (zadanyOperator == "-")
                        {
                            vysledek = cislo1 - cislo2;
                        }
                        else if (zadanyOperator == "*")
                        {
                            vysledek = cislo1 * cislo2;
                        }
                        else if (zadanyOperator == "/")
                        {
                            vysledek = cislo1 / cislo2;
                        }
                        Console.WriteLine($"Výsledek: {cislo1} {zadanyOperator} {cislo2} = {vysledek}");
                    }
                    else
                    {
                        Console.WriteLine("Neplatné číslo.");
                    }
                }
                else
                {
                    Console.WriteLine("Neplatný operátor.");
                }
            }
            else
            {
                Console.WriteLine("Neplatné číslo.");
            }
        }
    }
}
