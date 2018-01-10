using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 2;
            //int result = 0;
            int evenSum = 2;
            while (n2 <= 4000000)
            {
                //Print values to the console to confirm correct functionality during development
                Console.WriteLine($"N1: {n1}");
                Console.WriteLine($"N2: {n2}");
                int result = n1 + n2;
                n1 = n2;
                n2 = result;

                //Print to the console to confirm correct functionality during development
                Console.WriteLine($"Result: {result}");

                if (result % 2 == 0)
                {
                    evenSum += result;
                    //Print to the console to confirm correct functionality during development
                    Console.WriteLine($"\nEven Result: {evenSum}\n");
                }
            }
            Console.WriteLine($"Sum of all even even values in the Fibonacci sequence beginning with 1, 2 and not exceeding 4,000,000: {evenSum.ToString()}\n\n");
        }
    }
}
