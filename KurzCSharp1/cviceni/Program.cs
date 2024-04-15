namespace cviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //příklad 1 - cyklus ahoj
            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Ahoj");
            }

            // příklad 2 - sestupná čísla
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }


            // příklad 3 - uhádni náhodné číslo
 /*           Random generator = new Random();
            int nahodneCislo = generator.Next(11);
            Console.WriteLine(nahodneCislo);

            Console.WriteLine("Myslím si celé číslo, hádej 3x.");
            int tipovaneCislo = int.Parse(Console.ReadLine());


            for (int i = 1; i <= 2; i++)
            {
                if (tipovaneCislo == nahodneCislo)
                {
                    Console.WriteLine($"Uhold jsi! Je to {nahodneCislo}.");
                    return;
                }
                else
                {
                    Console.WriteLine("Kdepak. Hádej znovu.");
                    tipovaneCislo = int.Parse(Console.ReadLine());
                }
            }

            if (tipovaneCislo == nahodneCislo)
            {
                Console.WriteLine($"Uhold jsi! Je to {nahodneCislo}.");
                return;
            }
            else
            {
                Console.WriteLine("Kdepak!");
            }
 */



           // příklad 4 - hvězdičky
            for (int i = 1; i <= 1; i++)
            {
                string znak = "*";
                Console.WriteLine(znak);

                for (int j = 1; j <= 4; j++)
                {
                    znak = znak + "*";
                    Console.WriteLine(znak);
                }
            }

            
            // příklad 6 - největší zadané číslo
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










