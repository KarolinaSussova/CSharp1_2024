namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cislo1 = 0;
            int cislo2 = 1;
            int vysledek = 0;

            Console.WriteLine("Zadej množství čísel kolik se má z Fibbonacciho posloupnosti vypsat");
            int uzivatelemZadanyPocet = int.Parse(Console.ReadLine());

            if (uzivatelemZadanyPocet == 1)
            {
                Console.WriteLine("0");
            }
            else if (uzivatelemZadanyPocet > 1)
            {
                Console.WriteLine("Fibonacciho posloupnost je:");
                Console.WriteLine(cislo1);
                Console.WriteLine(cislo2);

                for (int i = 1; i <= (uzivatelemZadanyPocet - 2); i++)
                {
                    vysledek = cislo1 + cislo2;
                    cislo1 = cislo2;
                    cislo2 = vysledek;
                    Console.WriteLine(vysledek);
                }


            }
        }
    }
}
