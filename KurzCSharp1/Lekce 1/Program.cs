namespace Lekce_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // poznamka na radek//
            /* poznamka 
             * 
             * do bloku */

            Console.WriteLine("Hello, World!"); // tento radek vypise do konzole text
            Console.WriteLine();
            Console.WriteLine("Muj druhy text.");

            Console.Write("1");
            Console.Write("2");
            Console.Write("3");
            Console.WriteLine("");

            Console.ReadLine();
            Console.Beep();


            Console.WriteLine("Dobrý večer");

            //Po stisknutí klávesy Enter mu napíše tip, co by mohl právě teď udělat (usměj se, poskoč, zavři oči).

            Console.WriteLine("Stiskni enter");
            Console.ReadLine();
            Console.WriteLine('poskoč');

        }
    }
}


while (notFinished())
{
    moveForward();
    if (isPathRight())
    {
        turnRight();
    }
}



while (notFinished())
{
    if (isPathForward())
    {
        moveForward();
    }
    else
    {
        if (isPathRight())
        {
            turnRight();
        }
        else
        {
            turnLeft();
        }
    }
}