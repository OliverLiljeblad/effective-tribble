using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace effective_tribble
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter how many numbers you want: ");
            int min = int.MaxValue;
            int sum = 0;
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                int x =  int.Parse(Console.ReadLine());

                if (x < min)
                {
                    min = x;
                }

                sum = sum + x;
            }
           
            Console.Write("Your avg value is: ");
            Console.WriteLine((double)sum / number);

            Console.Write("Your minimum number is: ");
            Console.WriteLine(min);

            Console.Write("Press any key to EXIT");
            Console.ReadKey();
        }
    }
}
