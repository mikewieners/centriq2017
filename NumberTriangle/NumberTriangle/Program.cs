using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //print the first line of one character
            //increment the number of characters to print
            //make sure there are enough characters remaining to print
            //print them if there are
            string tryAgain = "y";

            while (tryAgain == "y" || tryAgain == "yes")
            {
                int numbersThisLine = 1;
                int numbersRemaining = 0;
                int numberToPrint = 1;

                Console.Write("Welcome to the Number Series Trianglinator. How high do you want to count?");

                try
                {
                    numbersRemaining = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("That is not a number. Please try again.");
                }

                while (numbersThisLine <= numbersRemaining)
                {
                    Console.WriteLine();

                    for (int i = 1; i <= numbersThisLine; i++)
                    {
                        Console.Write("{0} ", numberToPrint);
                        numberToPrint++;
                        numbersRemaining--;
                    }

                    Console.WriteLine();
                    numbersThisLine++;
                }
                
                Console.Write("\nWould you like to go again (yes/no)?");
                tryAgain = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
        }
    }
}
