namespace loop_procviceni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          //w3resource.com - for loop - ex. 2
                      int soucet = 0;
                      for (int i = 1; i <= 10; i++)
                      {
                          soucet = soucet + i;
                      }
                      Console.WriteLine(soucet);

                      //w3resource.com - for loop - ex. 5
                      for (int j = 1; j <= 5; j++)
                      {
                          int cube = j * j * j;
                          Console.WriteLine($"Třetí mocnina čisla {j} je {cube}");
                      }

                      //w3resource.com - for loop - ex. 6
                      int number = 15;
                      for (int k = 1; k <= 10; k++)
                      {
                          Console.WriteLine($"{number} x {k} = {number * k}");
                      }

                      //w3resource.com - for loop - ex. 7
                      int n = 8;

                      for (int o = 1; o <= 10; o++)
                      {
                          for (int p = 1; p <= n; p++)
                          {
                              Console.Write($"{p} x {o} = {p * o}, ");
                          }
                          Console.Write("\n");
                      }

                      //w3resource.com - for loop - ex. 8


                      int cislo = 1;
                      int cisloLiche;
                      int numberOfOdds = 1;
                      int soucet = 0;

                      while (numberOfOdds <= 10)
                      {
                          if (cislo % 2 != 0)
                          {
                              cisloLiche = cislo;
                              Console.Write(cisloLiche + ", ");
                              soucet = soucet + cisloLiche;
                              numberOfOdds++;
                          }               
                          cislo++;

                      }
                      Console.WriteLine(soucet);

                      int i, n, sum = 0;  // Declaration of variables 'i' for iteration, 'n' to store the input number of terms, 'sum' to calculate the sum

                      Console.Write("\n\n");  // Displaying new lines
                      Console.Write("Display the sum of n odd natural numbers:\n");  // Displaying the purpose of the program
                      Console.Write("------------------------------------------");  // Displaying a separator
                      Console.Write("\n\n");

                      Console.Write("Input number of terms : ");  // Prompting the user to input the number of terms
                      n = Convert.ToInt32(Console.ReadLine());  // Reading the number entered by the user

                      Console.Write("\nThe odd numbers are :");  // Displaying the start of the sequence of odd numbers

                      for (i = 1; i <= n; i++)  // Loop to generate 'n' odd natural numbers
                      {
                          Console.Write("{0} ", 2 * i - 1);  // Displaying each odd number in the sequence
                          sum += 2 * i - 1;  // Calculating the sum by adding each odd number
                      }

                     Console.Write("\nThe Sum of odd Natural Numbers up to {0} terms : {1} \n", n, sum);
             
            for (int q = 0; q <= 4; q++)
            {
                Console.Write(q + ", ");
            }

            int i = 0;
            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            string znak = "*";

            for (int h = 0; h < 5; h++)            
                {
                    Console.WriteLine(znak);
                    znak = znak + "*";
                }

            //w3resource.com - for loop - ex. 9
            int rows = 5;

            for (int a = 1; a <= rows; a++)  // Loop to iterate through each row
            {
                for (int b = 1; b <= a; b++)  // Loop to print '*' in each row based on the value of 'i'
                {
                    Console.Write("*");  // Displaying asterisks to form the pattern
                }
                Console.Write("\n");  // Moving to the next line to form the right-angled pattern
            }

            //w3resource.com - for loop - ex. 10
            for (int c = 1; c < 5; c++)
            {
                for (int d = 1; d <= c; d++)
                {
                    Console.Write(d);
                }
                Console.Write("\n");
            }

            //w3resource.com - for loop - ex. 11
            for (int e = 0; e < 4; e++)
            {
                for (int f = 0; f <= e; f++)
                {
                    Console.Write(e + 1);
                }
                Console.Write("\n");
            }
                       
            

            //w3resource.com - for loop - ex. 12
            int y = 0;
            for (int o = 1; o < 6; o++)      
            {
                
                for (int p = 1; p <= o; p++)
                {
                    y = y + 1;
                    Console.Write(y + " ");
                }
                Console.Write("\n");
            }


            int y = 0;
            for (int o = 1; o < 5; o++)
            {

                for (int p = 1; p <= o; p++)
                {
                    y = y + 1;
                    Console.Write(y + " ");
                }
                Console.Write("\n");
            }
*/
            double cislo1 = 8;
            double cislo2 = 2;
            double vysledek = 1;


            for (int x = 1; x <= cislo2; x++)
            {

                vysledek = vysledek * cislo1;             
                


            }

            Console.WriteLine(vysledek);

        }
    }
}



