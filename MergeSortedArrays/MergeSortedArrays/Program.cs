using System;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 6, 10, 11, 15 };
            int[] alicesArray = { 1, 5, 8, 12, 14, 19 };

            // Prints [1, 3, 4, 5, 6, 8, 10, 11, 12, 14, 15, 19]
            int[] mergedarray = MergeArrays(myArray, alicesArray);
            foreach (int num in mergedarray)
            {
                Console.WriteLine(num);
            }
        }

        // merge two sorted arrays
        // input: 2 sorted arrays
        // output: 1 combined sorted array
        // assumptions: both arrays are sorted, need to output a sorted array, no duplicates
        // constraints: can't use .Sort

        // steps:
        // 1. initialize two pointers: one for each array to keep track of the index
        // 2. walk through both arrays simultaneously and compare the two values
            // 2a. if one value is less than the other, add that value to the new array and move the pointer on that array
        // 3. at the end, add any remaining values to the array and return the array

        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            // pointers to keep track of where we are in each array
            int p1 = 0;
            int p2 = 0;
            int r = 0;
            // result array to hold values as we sort them
            int[] result = new int[array1.Length + array2.Length];

            // while pointers are still within bounds of arrays, compare the two values and add to result
            while (p1 < array1.Length && p2 < array2.Length)
            {
                // compare values in array1 and array2 and add the lower value
                if (array1[p1] < array2[p2])
                {
                    result[r] = array1[p1];
                    p1++;
                }
                else
                {
                    result[r] = array2[p2];
                    p2++;
                }
                r++;
            }

            // if there are still values we haven't checked in one of the arrays, add them to the result
            if (p1 < array1.Length)
            {
                result[r] = array1[p1];
                r++;
            }
            if (p2 < array2.Length)
            {
                result[r] = array2[p2];
            }
            return result;
        }
    }
}
