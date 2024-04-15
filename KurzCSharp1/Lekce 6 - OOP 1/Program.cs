namespace Lekce_6___OOP_1
{
   public class Auto
    {
        string Vyrobce;
        int PocetSedadel;
        int RokVyroby;
        string Barva;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.Vyrobce = "Fearrari";
            ferrari.PocetSedadel = 4;
            ferrari.RokVyroby = 1999;
            ferrari.Barva = "Červená";

        }
    }
}
