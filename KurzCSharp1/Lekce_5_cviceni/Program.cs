namespace Lekce_5_cviceni
{
    internal class Program
    {
        public static void PredstavSe(int vek)
        {
            string jmeno = "Jan";
            string prijmeni = "Skála";
            Console.WriteLine($"{jmeno} + {prijmeni}, věk: {vek}");
        }

        public static void PredstavSe(string jmeno, string prijmeni, int vek)
        {
            Console.WriteLine($"Jmenuji se {jmeno} {prijmeni}, je mi {vek} let");
        }

        public static string ZiskejTextovyVstupZKonzole()
        {
            Console.WriteLine("Sem zadej text:");
            string zadanyText = Console.ReadLine();
            return zadanyText;
        }


        static void Main(string[] args)
        {
            /// 1) Vytvořte metodu s nazvem ZiskejTextovyVstupZKonzole(), která se bude uživatele ptát na zadání libovolného textu (string).
            /// Dokud uživatel nezadá text správně, nechávejte uživatele pokusit se text zadat znovu.
            /// Jakmile zadá uživatel text správně, metoda navrátí tento text jako návratovou hodnotu.
            /// TIP: Budete určitě potřebovat while cyklus, TryParse, return
            /// Zavolejte tuto metodu v Main, uložte si výstup funkce a vypiště zadaný text zpátky do konzole.		
            ///
            /// 2) Udělejte to samé pro zadání libovolného desetinného čísla (double).
            /// Dokud uživatel nezadá správně desetinné číslo, nechávejte uživatele pokusit se číslo zadat znovu.
            /// Jakmile zadá uživatel desetinné číslo správně, metoda jej navrátí toto desetinné číslo jako návratovou hodnotu.
            /// Zavolejte tuto metodu v Main, uložte si výstup funkce a vypiště zadané desetinné číslo zpátky do konzole.		
            ///
            /// Bonus: 3) Přidejte metodám parametr typu string, ve kterém metodě předáte text,
            /// který se zobrazí v konzoli předtím, než se uživatel pokusí zadat svůj vstup.





            /// 1) Vytvořte metodu PredstavSe(), která vypíše do konzole jméno a příjmení. Jméno a příjmení si libovolně zvol a zadefinuj je přímo v tělu metody. 
            /// 2) Zavolej tuto metodu v Main. Zkontroluj, že v konzoli je očekávaný výstup.
            /// 3) Vytvořte metodu PredstavSe(int vek), která vypíše do konzole jméno, příjmení a věk (jeho hodnotu získáš v metodě pomocí parametru "vek"). 
            ///	   Jméno a příjmení si libovolně zvol a zadefinuj je přímo v tělu metody. 
            /// 4) Zavolej tuto metodu v Main. Vyzkoušej si, že v konzoli se vypisuje věk, který metodě předáš pomocí parametru "vek".
            ///		
            /// Bonus: 5) Vytvoř metodu PredstavSe, která bude příjímat parametry: jmeno, prijmeni, vek
            ///         Tato metoda pak vypíše do konzole text ve formátu:
            ///         Jmenuji se Pavel Novák, je mi 36 let. (Výpis do konzole v tomto případě odpovídá zavolání metody PredstavSe s hodnotami parametrů: "Pavel", "Novák", 36)
            /// 		Zavolej tuto metodu v Main, vyzkoušej si měnit parametry, ověř že výstup do koznole odpovídá parametrům.

            string jmeno = "Pavel";
            string prijmeni = "Novák";
            int vek = 44;

            PredstavSe(jmeno, prijmeni, vek);

            ZiskejTextovyVstupZKonzole();
            Console.WriteLine(ZiskejTextovyVstupZKonzole());


        }
    }
}
