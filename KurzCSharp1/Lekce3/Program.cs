using System.Diagnostics;

namespace Lekce3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cilovaStanice = "Brno";

            // použítití switche u případů kde víme kolik máme případů, v takovém se hodí více než else if

            switch (cilovaStanice)
            {
                case "Brno":
                    Console.WriteLine("Jedeme do Brna");
                    break;
                case "Praha":
                    Console.WriteLine("Jedeme do Prahy");
                    break;
                default:
                    Console.WriteLine("Sem nejedeme");
                    break;

            }
            Console.WriteLine("konec programu");

        }
    }
}
