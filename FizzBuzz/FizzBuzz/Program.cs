using System;
using System.IO;

namespace FizzBuzz
{
    /* Output numbers from 1 to x.
     * If the number is divisible by 3, replace it with "Fizz".
     * If it's divisible by 5, replace it with "Buzz".
     * If it's divisible by both 3 and 5, replace it with "FizzBuzz".
     * 
     * Sample input: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
     * Sample output: 1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz
     * assumptions: non-negative integers in an array
     * constraints: none
     * 
     * pseudocode:
     * 1. iterate through each int x in array
     * 2. if/else statements:
     *      if x%3 == 0 -> fizz
     *      if x%5 == 0 -> buzz
     *      if x%3 && x%5 == 0 -> fizzbuzz
     *      else write out x
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for FizzBuzz: ");
            int input = Console.ReadLine();
            FizzBuzz(input);

        }

        public static void FizzBuzz(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
