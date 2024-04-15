namespace ukol_8
{
    internal class Program
    {
        public static double ZadejAOverCislo()
        {
            Console.WriteLine("Zadej číslo:");
            string odpoved = Console.ReadLine();
            bool jeCislo = double.TryParse(odpoved, out double cislo);

            while (!jeCislo)
            {
                Console.WriteLine("Nesprávně zadané číslo, prosím zadej znovu:");
                jeCislo = double.TryParse(Console.ReadLine(), out cislo);
            }
            return cislo;
        }

        public static string ZadejAOverOperator()
        {
            Console.WriteLine("Zadej matematický operátor (+, - , *, /, ^). Zadáním 'X' kalkulačka končí.");
            string zadanyOperator = Console.ReadLine();

            while ((zadanyOperator != "+") && (zadanyOperator != "-") && (zadanyOperator != "*") && (zadanyOperator != "/") && (zadanyOperator != "^") && (zadanyOperator.ToUpper() != "X"))
            {
                Console.WriteLine("Nesprávně zadaný operátor, prosím zadej znovu:");
                zadanyOperator = Console.ReadLine();
            }
            return zadanyOperator.ToUpper();
        }


        static void Main(string[] args)
        {
            Kalkulacka prvniPocitani = new Kalkulacka();
            double cislo = ZadejAOverCislo();
            prvniPocitani.Pricti(cislo);

            while (true)
            {
                string zadanyOperator = ZadejAOverOperator();
                if (zadanyOperator == "X")
                {
                    Console.WriteLine("Kalkulačka končí.");
                    return;
                }
                else
                {
                    cislo = ZadejAOverCislo();

                    switch (zadanyOperator)
                    {
                        case ("+"):
                            prvniPocitani.Pricti(cislo);
                            break;
                        case ("-"):
                            prvniPocitani.Odecti(cislo);
                            break;
                        case ("*"):
                            prvniPocitani.Vynasob(cislo);
                            break;
                        case ("/"):
                            prvniPocitani.Vydel(cislo);
                            break;
                        case ("^"):
                            prvniPocitani.Umocni(cislo);
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine($"Výsledek: ");
                Console.WriteLine(prvniPocitani.VratAktualniVysledek());
            }
        }
    }
}

