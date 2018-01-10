using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARTPPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] stringArray;
            int nextChar;
            string returnMessage = "";
            string testAgain = "y";

            while (testAgain == "y" || testAgain == "yes")
            {
                Console.Write("Enter a string of characters to determine whether or not it's a palindrome: ");
                stringArray = Console.ReadLine().ToArray();
                nextChar = stringArray.Length - 1;

                if (nextChar == -1)
                {
                    Console.WriteLine("The entered string is empty.");
                }
                else
                {
                    if (nextChar == 0)
                    {
                        returnMessage = "The entered string is a palindrome.";
                    }
                }

                for (int i = 0; i <= nextChar + 1; i++)
                {
                    if (stringArray[i] == stringArray[nextChar])
                    {
                        returnMessage = "The entered string is a palindrome.";
                        nextChar--;

                    }
                    else
                    {
                        returnMessage = "The entered string is not a  palindrome.";
                        nextChar = 0;
                    }
                }

                Console.Write("\n{0} Would you like to test another string? (yes/no): ", returnMessage);
                testAgain = Console.ReadLine().ToLower();
                Console.WriteLine();
            }

        }
    }
}
