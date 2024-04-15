using System;

namespace Lekce2.Cviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo1 = 4;
            int cislo2 = 4;
            int vysledek = cislo1 + cislo2;
            Console.WriteLine($"Výsledek je {vysledek}");


            Console.WriteLine("Zadej uživatelské jméno: ");
            string uzivatelskeJmeno = Console.ReadLine();

            if (uzivatelskeJmeno.ToLower() == "admin")
            {
                Console.WriteLine("Jsi přihlášen s administrátorskými právy.");
            }
            else if (uzivatelskeJmeno.ToLower() == "user")
            {
                Console.WriteLine("Jsi přihlášen s uživatelskýni právy");
            }
            else
                Console.WriteLine("Uživatel neznámý. Nejsi přihlášen");

            int cislo = 15;
            Console.WriteLine("Tipni si číslo: ");
            int tip = int.Parse(Console.ReadLine());

            if (cislo > tip)
            {
                if ((cislo - tip) <= 5)
                {
                    Console.WriteLine("Tip je blízko");
                }
            }
            else if (tip > cislo)
            {
                if ((tip - cislo) <= 5)
                {
                    Console.WriteLine("Tip je blízko");
                }
            }
           
            
            if (tip > cislo)
            {
                Console.WriteLine("Tip je příliš vysoký");
            }
            else if (tip < cislo)
            {
                Console.WriteLine("Tip je příliš nízký");
            }
            else
            {
                Console.WriteLine("Hurá. Uhádl jsi!");
            }
        }
    }
}
