namespace Lekce2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celeCislo = 5;
            Console.WriteLine(celeCislo);

            int celeCisloDeklarace;
            celeCisloDeklarace = 42;
            Console.WriteLine(celeCisloDeklarace);

            int cislo1 = 2;
            int cislo2 = 5;
            int vysledek;

            vysledek = cislo1 + cislo2;
            Console.WriteLine("Vysledek souctu je: " + vysledek);
            vysledek = cislo1 - cislo2;
            Console.WriteLine("Vysledek rozdilu je: " + vysledek);
            vysledek = cislo2 / cislo1;
            Console.WriteLine(vysledek);

            string uvitaciText = "Ahoj Czechitas!";
            Console.WriteLine(uvitaciText);
            string pozdraveni = "Jak se dnes mate?";
            Console.WriteLine(uvitaciText + pozdraveni);

            double desetinneCislo1 = 3.14;
            double desetinneCislo2 = 5.89;
            double vysledekDesetinneCislo;

            vysledekDesetinneCislo = desetinneCislo2 / desetinneCislo1;
            Console.WriteLine("Vysledek deleni je: " + vysledekDesetinneCislo);

            Console.WriteLine("Uživateli zadej vstup:");
            string textZKonzole = Console.ReadLine();
            Console.WriteLine(textZKonzole);

            Console.WriteLine("Zadej své křestní jméno: ");
            string krestniJmeno = Console.ReadLine();
            Console.WriteLine("Zadej své příjmení: ");
            string prijmeni = Console.ReadLine();
            string celeJmeno = krestniJmeno + " " + prijmeni;
            Console.WriteLine("Tvůj věk je: ");
            int vek1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vaše křesní jméno je {krestniJmeno}, vaše příjmení je {prijmeni}, celým jménem se jmenujete {celeJmeno} a tvůj věk je {vek1}");

            Console.WriteLine("Zadej svůj věk: ");
            string vstupJakoText = Console.ReadLine();
            int vek = int.Parse(vstupJakoText);
            if (vek >= 18)
            {
                Console.WriteLine("Na zdraví!");
            }
            else if (vek <= 8)
            {
                Console.WriteLine("Jsi ještě dítě! ");
            }
            else
            {
                Console.WriteLine("Dospělým nenaléváme. ");
            }
            Console.WriteLine("Konec programu.");
        }
    }
}
