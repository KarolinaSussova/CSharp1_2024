namespace Lekce_7___konstruktor
{
    internal class Program
    {

        class BankovniUcet
        {
            public int cisloUctu;
            public string majitel;
            public double zustatek;

            public void VypisInformace();
            {

        }
    }
}




static void Main(string[] args)
{
    BankovniUcet mujUcet = new BankovniUcet();
    mujUcet.cisloUctu = 1;
    mujUcet.zustatek = 0.01;
    mujUcet.majitel = "Karolína";

    BankovniUcet tvujUcet = new BankovniUcet();
    mujUcet.cisloUctu = 2;
    mujUcet.zustatek = 10000;
    mujUcet.majitel = "Martin";

}
}



