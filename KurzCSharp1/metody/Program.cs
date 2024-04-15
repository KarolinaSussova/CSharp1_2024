namespace metody
{
    internal class Program
    {
        public static double ZadejAOverCislo()
        {

            Console.WriteLine("Zadej číslo:");
            bool jeCislo = double.TryParse(Console.ReadLine(), out double cislo);

            while (!jeCislo)
            {
                Console.WriteLine("Nesprávně zadané číslo, prosím zadej znovu:");
                jeCislo = double.TryParse(Console.ReadLine(), out cislo);
            }
            return cislo;
        }



        public static string ZadejAOverOperator()
        {
            Console.WriteLine("Zadej matematický operátor (+, - , *, /, ^) :");
            string zadanyOperator = Console.ReadLine();

            while ((zadanyOperator != "+") && (zadanyOperator != "-") && (zadanyOperator != "*") && (zadanyOperator != "/") && (zadanyOperator != "^"))
            {
                Console.WriteLine("Nesprávně zadaný operátor, prosím zadej znovu:");
                zadanyOperator = Console.ReadLine();
            }
            return zadanyOperator;
        }

        public static double Vypocet(double cislo1, double cislo2, string zadanyOperator)
        {
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
                case ("="):
                    break;
                default:
                    break;
            }
            return vysledek;
        }

        static void Main(string[] args)
        {

            
            while (true)
            {
                double cislo1 = ZadejAOverCislo();
                string zadanyOperator = ZadejAOverOperator();
                double cislo2 = ZadejAOverCislo();
                double vysledek = Vypocet(cislo1, cislo2, zadanyOperator);
                Console.WriteLine($"Výsledek {cislo1} {zadanyOperator} {cislo2} = {vysledek}");
                Console.WriteLine();
            }


        }
    }
}
