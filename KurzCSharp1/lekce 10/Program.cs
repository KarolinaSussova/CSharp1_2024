using System.Reflection.Metadata.Ecma335;

namespace lekce_10
{
    public class Statistika
    {
        int[] Cisla;

        public Statistika(int[] vstupniPoleCisel)
        {
            Cisla = vstupniPoleCisel;
        }

        public int VratSoucet()
        {
            int soucet = 0;
            for (int i = 0; i < Cisla.Length; i++)
            {
                soucet += Cisla[i];
            }
            return soucet;
        }

        public double VratPrumer()
        {
            double prumer = VratSoucet() / Cisla.Length;
            return prumer;
        }

        public int VratPocetCisel()
        {
            return Cisla.Length;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] poleCisel = new int[] { 1, 2, 3, 4, 5 };

            Statistika novaStatistika = new Statistika(poleCisel);

            Console.WriteLine($"počet čísel v poli je {novaStatistika.VratPocetCisel()}");
            Console.WriteLine($"průmer čísel v poli je {novaStatistika.VratPrumer()}");

        }
    }
}
