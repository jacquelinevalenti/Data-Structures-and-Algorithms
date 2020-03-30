using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(2));
        }


        // given an integer, return the corresponding number in the Fibonacci sequence
        // Fibonacci sequence: 1, 1, 2, 3, 5, 8, 13, etc.
        // input: 3
        // output: 2
        // input: 6
        // output: 8

        public static int Fibonacci(int index)
        {
            // basic formula: for some value n, n-2 + n-1 = n
            // we want to recursively call the Fibonacci function until n = 0
            if (index <= 1)
            {
                return index;
            }
            else
            {
                return Fibonacci(index - 2) + Fibonacci(index - 1);
            }
        }



    }
}
