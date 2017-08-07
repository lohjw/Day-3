using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program4
    {
        static void Main()
        {
            bool isParsable = false; // doesn't matter if true or false
            bool hasEnteredSomething = false;
            int value = 0;

            while (hasEnteredSomething == false || isParsable == false)
            {
                if (hasEnteredSomething == false)
                {
                    Console.Write("Please enter an integer: ");
                }
                else
                {
                    Console.Write("You did not enter an integer. \nPlease try again: ");
                }

                string input = Console.ReadLine();

                hasEnteredSomething = true;
                isParsable = Int32.TryParse(input, out value);
            }

            Console.WriteLine("The value you entered is {0}", value);

        }
    }
}
