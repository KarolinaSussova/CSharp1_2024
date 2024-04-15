namespace faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadej kladné celé číslo:");
            int cislo = int.Parse(Console.ReadLine());
            int faktorial = 0;

            if (cislo == 0)
            {
                faktorial = 1;
            }
            else
            {
                int nasobek = 1;
                for (int promenna = cislo; promenna >= 1; promenna--)
                {
                    nasobek = promenna * nasobek;
                    faktorial = nasobek;
                }
            }
            Console.WriteLine($"Faktoriál čísla {cislo} je {faktorial}.");


/*            int n = 6;
            int vysledek = 0;
            for (int x = 1; x <= n - 1; x++)
            {
                vysledek = x * n;
                Console.WriteLine($"{x} * {n}");

                for (int y = 1; y < x; y++)
                {
                    vysledek = x * y * n;
                    Console.WriteLine($"{x} * {y} * {n}");

                    for (int u = 1; u < y; u++)
                    {
                        vysledek = x * y * u * n;
                        Console.WriteLine($"{x} * {y} * {u} * {n}");

                        for (int v = 1; v < u; v++)
                        {
                            vysledek = x * y * u * v * n;
                            Console.WriteLine($"{x} * {y} * {u} * {v} * {n}");

                            for (int w = 1; w == n - n + 1; w++)
                            {
                                vysledek = x * y * u * v * w * n;
                                Console.WriteLine($"{x} * {y} * {u} * {v} * {w} * {n}");


                            }

                        }
                    }

                }
                Console.WriteLine($"konečný výsledek: {vysledek}");

                */
        }
    }
}

