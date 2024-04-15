using System;

namespace Lekce3_napoje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Výběr nápoje:
            // Vytvoř celočíselnou proměnnou cisloNapoje typu int.
            // Vypiš do konzole nabídku nápojů:
            // 1 - Káva
            // 2 - Čaj
            // 3 - Limonáda
            // 4 - Voda
            // Požádej uživatele, aby zadal číslo nápoje a hodnotu ulož do proměnné cisloNapoje.

            // Použití switch:
            // Použij příkaz switch na proměnnou cisloNapoje.
            // Pro každou možnost (1 - 4) vypiš do konzole odpovídající zprávu (např. "Vybrali jste kávu").
            // Přidej default pro případ nápoje, který není v menu - bude vypisovat "Neznámý výběr nápoje".

            // Rozšíření:
            // Přidej proměnnou mnozstvi typu int pro množství nápoje.
            // Po výběru nápoje požádej uživatele, aby zadal množství.
            // Vypiš do konzole celkovou zprávu, například "Vybrali jste 2 kávy".


            int cisloNapoje;
            int pocetObjednanychNapoju;
            string nabidkaNapoju = "1 - Káva\n2 - čaj\n3 - limonáda\n4 - voda";

            Console.WriteLine(nabidkaNapoju);
            Console.WriteLine("Zadejte číslo vámi zvoleného nápoje: ");
            cisloNapoje = int.Parse(Console.ReadLine());
          

            switch (cisloNapoje)
            {
                case 1:
                    Console.WriteLine("Vybrali jste kávu.");
                    break;
                case 2:
                    Console.WriteLine("Vybrali jste čaj.");
                    break;
                case 3:
                    Console.WriteLine("Vybrali jste limonádu.");
                    break;
                case 4:
                    Console.WriteLine("Vybrali jste vodu.");
                    break;
                default:
                    Console.WriteLine("Neznámý výběr nápoje.");
                    break;

            
            }
            Console.WriteLine("Zadejte počet objednávaných nápojů: ");
            pocetObjednanychNapoju = int.Parse(Console.ReadLine());
            string sklonovaniNapoje = "";

            switch (cisloNapoje)
            {
                case 1:
                    if (pocetObjednanychNapoju == 1)
                    {
                        sklonovaniNapoje = "kávu";
                    }
                    else if (pocetObjednanychNapoju < 4)
                    {
                        sklonovaniNapoje = "kávy";
                    }
                    else if (pocetObjednanychNapoju >= 5)
                    {
                        sklonovaniNapoje = "káv";
                    }
                    break;
                case 2:
                    if (pocetObjednanychNapoju == 1)
                    {
                        sklonovaniNapoje = "kávu";
                    }
                    else if (pocetObjednanychNapoju < 4)
                    {
                        sklonovaniNapoje = "kávy";
                    }
                    else if (pocetObjednanychNapoju >= 5)
                    {
                        sklonovaniNapoje = "káv";
                    }
                    break;
            }
            Console.WriteLine($"Vybrali jste {pocetObjednanychNapoju} {sklonovaniNapoje}");


        }
    }
}
