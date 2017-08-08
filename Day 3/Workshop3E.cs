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

            /* Question 1b
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = number; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            */

            /* Question 2
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} {1:0.0##} {2:0.0###} {3}", i, 1.0/i, Math.Sqrt(i), i*i);
            }
            */

            /* Question 3
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int k = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
            */

            /* Question 4
            int number;
            int sum = 0;
            int n;
            Console.Write("Enter the Number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is a perfect number");
            }
            else
            {
                Console.WriteLine("Entered number is not a perfect number");
            }
            */

            /* Question 5 

            int i = 1;
            int j = 1;

            for (i = 5; i <= 10000; i++)
            {
                int k = 0;

                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 2)
                {
                    Console.WriteLine(i);
                }

            }
            */

            /* Question 6

            int i;
            int j;

            for (i = 1; i <= 1000; i++)
            {
                int sum = 0;

                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }

            }
            */



        }
    }
}
