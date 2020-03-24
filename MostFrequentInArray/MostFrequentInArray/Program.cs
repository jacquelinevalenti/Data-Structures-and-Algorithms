using System;
using System.Collections.Generic;

namespace MostFrequentInArray
{
    class Program
    {
        /* find the most frequent number in an array
         * example: given [1, 2, 1, 3, 2, 1] output 1
         * if it's an empty array, output null
         * assumptions: there will always be a distinct answer
         */

        public static void Main(string[] args)
        {
            Console.WriteLine("How many values do you want in your array? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Please type a value to be put in the array followed by the enter key: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The most common value in your array is: {mostFreq(arr)}");
            
        }

        public static int mostFreq(int[] arr)
        {
            int maxCount = 0;
            int maxValue = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);
                }
                else
                {
                    dict[arr[i]] += 1;
                }
                if (dict[arr[i]] > maxCount)
                {
                    maxCount = dict[arr[i]];
                    maxValue = arr[i];
                }
            }
            return maxValue;
        }

    }
}
