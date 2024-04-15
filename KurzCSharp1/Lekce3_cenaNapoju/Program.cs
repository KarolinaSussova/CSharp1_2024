namespace Lekce3_cenaNapoju
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Výpočet ceny nápoje:
            // Pomocí Console.WriteLine Vypiš do konzole výzvu pro uživatele, aby zadal cenu nápoje.
            Console.WriteLine("Zde zadej cenu nápoje");
            // Cena by měla být zadaná jako číslo s plovoucí desetinnou čárkou (například 1.5 pro Kávu).
            // Načti si uživatelský vstup pomocí Console.ReadLine() a ulož ho do proměnné vstupCenaNapoje.

            // Použití double.TryParse:
            // Vytvořte proměnnou cenaNapoje typu double pro uložení výsledku převodu.
            //double cenaNapoje;

            // Použijte metodu double.TryParse s uživatelským vstupem vstupCenaNapoje a proměnnou cenaNapoje
            // double.TryParse vrátí boolovskou hodnotu, kterou uložte do proměnné jeCenaPlatna.
            //bool jeCenaPlatna = double.TryParse(Console.ReadLine(), out cenaNapoje);

            bool jeCenaPlatna = double.TryParse(Console.ReadLine(), out double cenaNapoje);

            // Výpočet celkové ceny:
            // Pokud byl vstup úspěšně převeden (jeCenaPlatna je true), vypiš do konzole výzvu pro zadání počtu nápojů.
            // Použij int.TryParse pro převod počtu nápojů na číslo a ulož výsledek do proměnné pocetNapoju.
            // Vypočítej celkovou cenu (cena nápoje * počet nápojů) a vypiš výsledek.
            // Pokud nebyl vstup úspěšně převeden, vypiš varovnou zprávu o neplatném zadání ceny.
            if (jeCenaPlatna == true)
            {
                Console.WriteLine("Zadej počet nápojů");
                int pocetNapoju;
                bool platnyPocetNapoju = int.TryParse(Console.ReadLine(), out pocetNapoju);
                if (platnyPocetNapoju == true)
                {
                    double celkovaCena = cenaNapoje * pocetNapoju;
                    Console.WriteLine($"Celková cena je {celkovaCena}");
                }
                else
                    Console.WriteLine("Toto není platný počet nápojů");
            }
            else
            {
                Console.WriteLine("Tato cena není platná");
            }


            // 2) BONUS na bool:
            // Definuj čtyři boolovské proměnné: jeSvatek, jeVikend, maDovolenou, jeNemocny.
            // Nastav jejich hodnoty na true nebo false.
            // Pokud je svátek NEBO vikend NEBO má uživatel dovolenou NEBO je nemocný, vypiš do konzole, že uživatel zůstane doma, jinak jde do práce.
            // Použij vhodné operátor
        }
    }
}
