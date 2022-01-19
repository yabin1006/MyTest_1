using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity3_SumNumber_Robin
{
    class Program
    {
        static void Main(string[] args)
        {
            char count;
            do
            {
                int summ = 0; int numInt = 0; count = 'y';
                Console.WriteLine("\nEnter a few integers for summary!");
                Console.Write("\nEnter 1st interger (0 to stop): ");
                do
                {
                    /* Input validation check */
                    while (!int.TryParse(Console.ReadLine(), out numInt))
                    {
                        Console.Write("\nEnter number is NOT valid, try again: ");
                    }
                    /* 0 to stop enter */
                    if (numInt == 0) break;
                    summ += numInt;
                    Console.Write("\nEnter next integer (0 to stop): ");
                } while (numInt != 0);

                Console.WriteLine($"\nThe summary is {summ}");

                /*Play again question*/
                do
                {
                    Console.Write("\nCalculate another sum? [Y/N]: ");
                    count = (char)Console.ReadKey().KeyChar;
                    if (count == 'y' || count == 'Y' || count == 'n' || count == 'N')
                    {
                        break;
                    }
                    else
                    {
                        count = 'g'; 
                    }
                } while (count == 'g');
                
            } while (count == 'y'|| count == 'Y');
        }
    }
}
