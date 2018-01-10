using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int countTo;
            string outputString = "";

            Console.Write("Enter a number:");
            countTo = Convert.ToInt32(Console.ReadLine());

            outputString = CountToString(countTo, start, outputString);

            Console.WriteLine($"\n{outputString}");
        }

        public static string CountToString(int countTo, int startFrom, string output)
        {
            string countOutput = output;
            if (countTo >= startFrom)
            {
                if (countOutput == "")
                {
                    countOutput = startFrom.ToString();
                    startFrom++;
                    countOutput = CountToString(countTo, startFrom, countOutput);
                }
                else
                {
                    countOutput = output + ", " + startFrom.ToString();
                    startFrom++;
                    countOutput = CountToString(countTo, startFrom, countOutput);
                }
            }
            else
            {
                return countOutput;
            }

            return countOutput;
        }
    }
}
