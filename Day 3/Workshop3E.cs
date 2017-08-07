using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Workshop3E
    {
        static void Main()
        {

            /* Question 1a
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            */

            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i == 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);

        }
    }
}
