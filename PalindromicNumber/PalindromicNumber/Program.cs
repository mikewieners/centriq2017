using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindromeString = "0";
            int n1 = 0;
            int n2 = 0;

            for (int i1 = 100; i1 < 1000; i1++)
            {
                for (int i2 = 100; i2 < 1000; i2++)
                {
                    int numberToCheck = i1 * i2;
                    if (checkForPalindrome(numberToCheck) && numberToCheck > Convert.ToInt32(palindromeString))
                    {
                        palindromeString = (i1 * i2).ToString();
                        n1 = i1;
                        n2 = i2;
                    }
                }
            }

            Console.WriteLine(palindromeString);
            Console.WriteLine(n1.ToString());
            Console.WriteLine(n2.ToString());
        }

        public static bool checkForPalindrome(int value)
        {
            char[] stringArray = value.ToString().ToArray();
            int nextChar = stringArray.Length - 1;
            bool isPalindrome = false;


            for (int i = 0; i < nextChar + 1; i++)
            {
                if (stringArray[i] == stringArray[nextChar])
                {
                    isPalindrome = true;
                    nextChar--;

                }
                else
                {
                    isPalindrome = false;
                    nextChar = 0;
                }
            }
            return isPalindrome;
        }
    }
}
