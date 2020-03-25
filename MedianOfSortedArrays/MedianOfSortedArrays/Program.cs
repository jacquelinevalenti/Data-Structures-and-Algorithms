using System;

namespace MedianOfSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5, 7, 9 };
            int[] array2 = { 2, 4, 6, 8, 10 };

            int[] sortedArray = MergeSort(array1, array2);
            foreach (int item in sortedArray)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine();
            Console.WriteLine(FindMedian(array1, array2));
        }

        // Find the median of two sorted arrays
        // Inputs: two integer arrays
        // Output: one integer representing the median value of all values in the two arrays
        // assumptions: both arrays are sorted, arrays can be of variable lengths, no duplicates
        // constraints: can't use any sort of math function
        // median = middle point of a set of numbers; need to have all numbers in order together and then find the midpoint
        // question: what happens if you have an even number of values after merging the two arrays?
            // either return both middle numbers or return the midpoint of the two values?
            // for this case I'll return the midpoint of the two values

        // steps:
        // 1. merge the two arrays into one array (merge sort)
            // first method
        // 2. if odd number of values, find the midpoint and return the value at that index
        // 3. if even number of values, find the two midpoint numbers and calculate the average of those two values
            // second method

        public static int[] MergeSort(int[] array1, int[] array2)
        {
            // initialize pointers for array1, array2, and sortedArray
            int s = 0;
            int p1 = 0;
            int p2 = 0;
            int[] sortedArray = new int[array1.Length + array2.Length];

            // while we're still within the bounds of both arrays, 
            while (p1 < array1.Length && p2 < array2.Length)
            {
                // compare indexes and add lower value to new array
                if (array1[p1] < array2[p2])
                {
                    sortedArray[s] = array1[p1];
                    p1++;
                }
                else
                {
                    sortedArray[s] = array2[p2];
                    p2++;
                }
                s++;
            }
            // add any leftover elements of either array
            while (p1<array1.Length)
            {
                sortedArray[s] = array1[p1];
                p1++;
                s++;
            }
            while (p2 < array2.Length)
            {
                sortedArray[s] = array2[p2];
                p2++;
                s++;
            }

            return sortedArray;
        }
        public static double FindMedian (int[] array1, int[] array2)
        {
            int[] sortedArray = MergeSort(array1, array2);
            double result;
            // if sortedarray length is odd, find the midpoint and return value
            if (sortedArray.Length % 2 != 0) // array of length 5 would result 1; enters if statement
            {
                // int division results in chopping off the decimal (rounding down)
                int midpoint = sortedArray.Length / 2;
                result = Convert.ToDouble(sortedArray[midpoint]);
                return result;
            }
            // if mod operation is 0, sortedarray length is even
            // find two midpoints and return their average
            else
            {
                // upper midpoint
                int midpoint1 = (sortedArray.Length / 2);
                // lower midpoint
                int midpoint2 = (sortedArray.Length / 2) - 1;
                result = (sortedArray[midpoint1] + sortedArray[midpoint2]) / 2.0;
                return result;
            }
        }
    }
}
