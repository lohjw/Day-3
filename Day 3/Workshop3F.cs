using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Workshop3F
    {
        static void Main()
        {

            /* Question 1a
            int vowelCount = 0;
            int j = 0;
            string a = "a";
            string e = "e";
            string i = "i";
            string o = "o";
            string u = "u";

            Console.Write("Please enter a string: ");
            string phrase = Console.ReadLine().ToLower();

            for (j = 0; j < phrase.Length; j++)
            {
                string test = phrase.Substring(j, 1);

                if (test.Equals(a) || test.Equals(e) || test.Equals(i) || test.Equals(o) || test.Equals(u))
                {
                    vowelCount = vowelCount + 1;
                }
            }

            Console.WriteLine("Total count of vowels are {0}.",vowelCount);
            */

            /* Question 1b
            int vowelCountA = 0;
            int vowelCountE = 0;
            int vowelCountI = 0;
            int vowelCountO = 0;
            int vowelCountU = 0;
            int j = 0;
            string a = "a";
            string e = "e";
            string i = "i";
            string o = "o";
            string u = "u";

            Console.Write("Please enter a string: ");
            string phrase = Console.ReadLine().ToLower();

            for (j = 0; j < phrase.Length; j++)
            {
                string test = phrase.Substring(j, 1);

                if (test.Equals(a))
                {
                    vowelCountA = vowelCountA + 1;
                }
                if (test.Equals(e))
                {
                    vowelCountE = vowelCountE + 1;
                }
                if (test.Equals(i))
                {
                    vowelCountI = vowelCountI + 1;
                }
                if (test.Equals(o))
                {
                    vowelCountO = vowelCountO + 1;
                }
                if (test.Equals(u))
                {
                    vowelCountU = vowelCountU + 1;
                }

            }

            int vowelCount = vowelCountA + vowelCountE + vowelCountI + vowelCountO + vowelCountU;

            Console.WriteLine("Total count of vowels are: {0}\nA vowels: {1}\nE vowels: {2}\nI vowels: {3}\nO vowels: {4}\nU vowels: {5}", vowelCount, vowelCountA, vowelCountE, vowelCountI, vowelCountO, vowelCountU);
            */

            /* Question 2
            string s = "";
            string revs = "";
            Console.WriteLine("Enter string: ");
            s = Console.ReadLine();

            for (int i = s.Length - 1; i >= 0; i--) // String Reverse
            {
                revs = revs + s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not
            {
                Console.WriteLine("String is Palindrome \nEntered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \nEntered String Was {0} and reverse string is {1}", s, revs);
            }
            */

        }
    }
}
