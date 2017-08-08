using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Workshop3D
    {
        static void Main()
        {

            /* Question 1
            int lucky = 88;
            bool correctGuess = false;

            do
            {
                Console.WriteLine("Please enter an integer: ");
                int guess = Int32.Parse(Console.ReadLine());

                if (lucky == guess)
                {
                    correctGuess = true;
                }

            } while (correctGuess == false);

            Console.WriteLine("Lucky you...");
            */

            /* QUESTION 2 - Wrong - to revise
            Console.WriteLine("Please enter value for A: ");
            int A = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter value for B: ");
            int B = Int32.Parse(Console.ReadLine());

            int LCM = 0;
            int HCF = 0;

            if ( A > B )
            {
                do
                {
                    HCF = A - B;
                } while (HCF != B);

            }
            else
            {
                do
                {
                    HCF = B - A;
                } while (HCF != A);
            }

            LCM = (A * B) / HCF;

            Console.WriteLine("HCF is: {0} \nLCM is: {1}", HCF, LCM);
            */

            /* Question 2
            Console.Write("Please enter first number: ");
            int A = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            int B = Int32.Parse(Console.ReadLine());
            int multiplied = A * B;

            while (A != B)
            {
                if (A > B)
                {
                    A = A - B;
                }
                else
                {
                    B = B - A;
                }
            }

            int HCF = A;
            int LCM = multiplied / HCF;
            Console.WriteLine("HCF: {0}\nLCM: {1}", HCF, LCM);
            */

            /* Question 3a
            Random r = new Random();
            int secret = r.Next(0, 10); // number range from 0 to 9
            bool correctGuess = false;
            int count = 0;

            do
            {
                Console.WriteLine("Please guess (0 to 9): ");
                int guess = Int32.Parse(Console.ReadLine());
                count = count+1;

                if (secret == guess)
                {
                    correctGuess = true;
                }

            } while (correctGuess == false); // !correctGuess

            Console.WriteLine("Congratulations, you have gotten the correct number.\nYou only took {0} tries.", count);
            */

            /* Question 4
            Random r = new Random();
            int secret = r.Next(0, 10); // number range from 0 to 9
            bool correctGuess = false;
            int count = 0;

            do
            {
                Console.WriteLine("Please guess (0 to 9): ");
                int guess = Int32.Parse(Console.ReadLine());
                count = count + 1;

                if (secret == guess)
                {
                    correctGuess = true;
                }
                else
                {
                    Console.WriteLine("Try again.");
                }

            } while (correctGuess == false);

            if (count > 0 && count <= 2)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (count > 2 && count <= 5 )
            {
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("You are lousy!");
            }
            */

            /* Question 4
            Console.WriteLine("Please enter a value: ");
            double N = Convert.ToDouble(Console.ReadLine());

            Random r = new Random();
            double G = r.Next(1, Convert.ToInt32(N));

            while (Math.Abs(G*G-N)>0.00001)
            {
                G = (G + (N / G)) / 2;
            } 

            Console.WriteLine(G);
            */

        }
    }
}
