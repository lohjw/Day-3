using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program5
    {
        static void Main()
        {
            Random r = new Random(); // creating a new random object
            for (int i = 0; i < 10; i++)
            {
                int value = r.Next(100);
                Console.WriteLine(value);
            }
        }
    }
}
