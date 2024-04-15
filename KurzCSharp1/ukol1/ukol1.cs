namespace ukol1
{
    internal class ukol1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej první číslo:");
            double cislo1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej matematický operátor (+, - , *, /)");
            string matematickyOperator = Console.ReadLine();
            Console.WriteLine("Zadej druhé číslo:");
            double cislo2 = double.Parse(Console.ReadLine());
            double vysledek;

            if (matematickyOperator == "+")
            {
                vysledek = cislo1 + cislo2;
                Console.WriteLine($"Výsledek je {vysledek}");
            }
            else if (matematickyOperator == "-")
            {
                vysledek = cislo1 - cislo2;
                Console.WriteLine($"Výsledek je {vysledek}");
            }
            else if (matematickyOperator == "*")
            {
                vysledek = cislo1 * cislo2;
                Console.WriteLine($"Výsledek je {vysledek}");
            }
            else if (matematickyOperator == "/")
            {
                vysledek = cislo1 / cislo2;
                Console.WriteLine($"Výsledek je {vysledek}");
            }
            else
            {
                Console.WriteLine("Zadal jsi neplatný operátor.");
            }
        }
    }
}
