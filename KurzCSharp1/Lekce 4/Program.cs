using Microsoft.VisualBasic;

namespace Lekce_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*           int cislo = 0;
                       while (cislo < 5)
                       {
                           Console.WriteLine("Ahoj");
                           cislo = cislo + 1;
                       }

                       Console.WriteLine("Uhodni celé číslo. Mezi 1 a 5.");
                       string number = "4";
                       string guess = Console.ReadLine();

                       while (guess != number)
                       {
                           Console.WriteLine("Zkus to znovu");
                           guess = Console.ReadLine();
                       }

                       Console.WriteLine("Uhodls!");


                       for (int i = 10; i > 9; i--)
                       {
                           Console.WriteLine(i);
                       }

                       int z = 0;
                       while (true)
                       {
                           Console.WriteLine(z);
                           z++;
                           if (z == 1) break;
                       }

                       int y = 0;
                       for (int x = 1; x < 30; x++)
                       {
                           if ((x % 7) == 0)
                           {
                               y++;
                           }
                       }
                       Console.WriteLine(y);

                       // Vytvorte cyklus pomoci while, ktery se uzivatele bude ptat na jeho rok narozeni
                       // tak dlouho, dokud uzivatel nezada spravne cislo (pouzijte TryParse).
                       // Kdyz zada spravne cislo, vypocitejte a vypiste jeho vek.

                       Console.WriteLine("Zadej rok narození");

                       int year = 0;
                       bool yearIsValid = int.TryParse(Console.ReadLine(), out year);
                       while (!yearIsValid || year > 2024 || year < 1900) 
                       {
                           Console.WriteLine("Špatně, Zadej znovu.");
                           yearIsValid = int.TryParse(Console.ReadLine(), out year);
                       }

                       Console.WriteLine($"Tvůj věk je {2024 - year} let");
           */
            int y = 0;
            for (int x = 1; x < 101; x++)
            {
                if ((x % 7) == 0) continue;
                y++;
            }
            Console.WriteLine(y);

            // Trenink na for cykly
            // Cyklus, ktery vypise poporade vsechna cisla od 0 do 20
            // modifikujte cyklus tak, aby vypsal jen suda cisla (vyuzij k vyberu pouze sudych cisel iteracni promennou)
            // volitelne si od uzivatele vyzadejte pocatecni a koncova cisla, aby mohl vypsat napr. vsechna suda cisla od 100 od 200
            // BONUS: ptej se uzivatele na cislo do te doby, dokud ho nezada spravne :-) (TryParse)

            Console.WriteLine("Zadej počáteční sudé číslo.");
            bool pocatekSpravny = int.TryParse(Console.ReadLine(), out int pocatek);
            while(!pocatekSpravny || (pocatek % 2 != 0))
            {
                Console.WriteLine("Nesprávně zadané číslo, zadej jej znovu");
                pocatekSpravny = int.TryParse(Console.ReadLine(), out pocatek);
            }

            Console.WriteLine("Zadej konečné číslo.");
            bool konecSpravny = int.TryParse(Console.ReadLine(), out int konec);
            while (!konecSpravny)
            {
                Console.WriteLine("Nesprávně zadané číslo, zadej jej znovu");
                konecSpravny = int.TryParse(Console.ReadLine(), out konec);
            }


            for (int i = pocatek; i <= konec ; i+=2)
            {
                Console.WriteLine(i);
            }



        }
    }
}
