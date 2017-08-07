using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program6
    {
        static void Main()
        {
            // pick a random number
            Random r = new Random();
            int secret = r.Next(0, 10); // number range from 0 to 9
            bool correctGuess = false;

            do
            {
                // ask user for a guess
                Console.WriteLine("Please guess (0 to 9): ");
                int guess = Int32.Parse(Console.ReadLine());

                if (secret == guess)
                {
                    correctGuess = true;
                }

            } while (correctGuess == false); // !correctGuess


            // if guess is successful. congratulate the user
            Console.WriteLine("Congratulations, you have gotten the correct number.");

            // else, repeat
        }
    }
}
