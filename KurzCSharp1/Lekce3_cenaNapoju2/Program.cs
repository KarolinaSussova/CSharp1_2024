namespace Lekce3_cenaNapoju2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Výpočet ceny nápoje:
            // Pomocí Console.WriteLine Vypiš do konzole výzvu pro uživatele, aby zadal cenu nápoje.
            // Cena by měla být zadaná jako číslo s plovoucí desetinnou čárkou, takže double (například 1.5 pro Kávu). 
            // Načti si uživatelský vstup pomocí Console.ReadLine() a ulož ho do proměnné vstupCenaNapoje.
            // Použití double.TryParse:
            // Vytvořte proměnnou cenaNapoje typu double pro uložení výsledku převodu.
            // Použijte metodu double.TryParse s uživatelským vstupem vstupCenaNapoje a proměnnou cenaNapoje.
            // double.TryParse vrátí boolovskou hodnotu, kterou uložte do proměnné jeCenaPlatna.
            // Výpočet celkové ceny:
            // Pokud byl vstup úspěšně převeden (jeCenaPlatna je true), vypiš do konzole výzvu pro zadání počtu nápojů.
            // Použij int.TryParse pro převod počtu nápojů na číslo a ulož výsledek do proměnné pocetNapoju.
            // Vypočítej celkovou cenu (cena nápoje * počet nápojů) a vypiš výsledek.
            // Pokud nebyl vstup úspěšně převeden, vypiš varovnou zprávu o neplatném zadání ceny.

            Console.WriteLine("Zadej cenu nápoje jako desetinné číslo s čárkou");
            bool jeCenaPlatna = double.TryParse(Console.ReadLine(), out double cenaNapoje);

            if (jeCenaPlatna == true)
            {
                Console.WriteLine("Prosím zadej počet objednávaných nápojů");
                bool jePocetPlatny = int.TryParse(Console.ReadLine(), out int pocetNapoju);
                if (jePocetPlatny)
                {
                    double celkovaCena = cenaNapoje * pocetNapoju;
                    Console.WriteLine($"Celková cena za objednání nápojů je {celkovaCena}");
                }
                else
                {
                    Console.WriteLine("Neplatný počet objednávaných nápojů.");
                }
            }
            else
            {
                Console.WriteLine("Neplatná cena nápoje.");
            }

            // 2) BONUS na bool:
            // Definuj čtyři boolovské proměnné: jeSvatek, jeVikend, maDovolenou, jeNemocny.
            // Nastav jejich hodnoty na true nebo false.
            // Pokud je svátek NEBO vikend NEBO má uživatel dovolenou NEBO je nemocný, vypiš do konzole, že uživatel zůstane doma, jinak jde do práce.
            // Použij vhodné operátory (|| a &&) pro sestavení tohoto výrazu.

            bool jeSvatek = false;
            bool jeVikend = false;
            bool maDovolenou = false;
            bool jeNemocny = false;

            if (jeSvatek || jeVikend || maDovolenou || jeNemocny)
            {
                Console.WriteLine("Zůstaň doma.");
            }
            else
            {
                Console.WriteLine("Jdi do práce.");
            }
        }
    }
}
