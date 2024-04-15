namespace Lekce8
{
     
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          Rytir filip = new Rytir
                      {
                          Jmeno = "Filip",
                          PocetZivotu = 1,
                          Sila = 1,
                      };
            */

            Rytir filip = new Rytir("Filip", 2, 10);
            Rytir karel = new Rytir("Karel", 2, 10);
            Rytir jan = new Rytir("Jan", 2, 10);
            Rytir franta = new Rytir("Franta");

            Console.WriteLine($"Mám v boji {Rytir.PocetRytiru} rytířů");

            Drak bonifac = new Drak();
            bonifac.Jmeno = "Bonifác";
            bonifac.Sila = 10;
            bonifac.PocetHlav = 3;

            filip.PredstavSe();
            bonifac.PredstavSe();
            
            while (bonifac.PocetHlav > 0)
            {
                filip.UtocimNaDraka();
                bonifac.ZasazeniRitirem();
            }

        }
    }
}
