namespace Lekce3_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jeDobrePocasi = true;
            bool jsemZdravy = false;

            if (jeDobrePocasi && jsemZdravy)
            {
                Console.WriteLine("Jdu ven");
            }
            else
            {
                Console.WriteLine("Nejdu nikam");
            }
        }
    }
}
