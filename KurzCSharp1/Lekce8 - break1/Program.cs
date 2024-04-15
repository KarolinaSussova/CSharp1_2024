namespace Lekce8___break1
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Obdelnik obdelnik1 = new Obdelnik(23, 12);
            Obdelnik obdelnik2 = new Obdelnik(20, 10);
            Obdelnik obdelnik3 = new Obdelnik(10);

            Console.WriteLine(obdelnik3.VypocitejObsah());

            Console.WriteLine($"Počet vytvořených obdelníků je {Obdelnik.PocetObdelniku}");
        }
    }
}
