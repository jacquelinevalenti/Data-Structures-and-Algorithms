using System;
using System.Collections.Generic;

namespace CommonElementsInTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: The following input values are used for testing your solution.

            int[] array1A = { 1, 3, 4, 6, 7, 9 };
            int[] array2A = { 1, 2, 4, 5, 9, 10 };
            // commonElements(array1A, array2A) should return [1, 4, 9] (an array).

            int[] array1B = { 1, 2, 9, 10, 11, 12 };
            int[] array2B = { 0, 1, 2, 3, 4, 5, 8, 9, 10, 12, 14, 15 };
            // commonElements(array1B, array2B) should return [1, 2, 9, 10, 12] (an array).

            int[] array1C = { 0, 1, 2, 3, 4, 5 };
            int[] array2C = { 6, 7, 8, 9, 10, 11 };
            // common_elements(array1C, array2C) should return [] (an empty array).

            int[] result = commonElements(array1C, array2C);
            foreach (int item in result)
            {
                Console.Write($"{item}  ");
            }

            int[] result2 = commonElements2(array1B, array2B);
            foreach (int item in result2)
            {
                Console.Write($"{item}  ");
            }
            
        }

        // My solution
        public static int[] commonElements(int[] array1, int[] array2)
        {
            // initialize a list to hold all of array1
            List<int> list1 = new List<int>();

            // initialize a list to hold common elements
            List<int> list2 = new List<int>();

            // add elements of array1 to list1
            foreach (int item in array1)
            {
                list1.Add(item);
            }

            // loop through array2 and compare value to values in list1
            // add to list2 if value is found in list1
            for (int i = 0; i < array2.Length; i++)
            {
                if (list1.Contains(array2[i]))
                {
                    list2.Add(array2[i]);
                }
            }

            // convert to an array and return
            int[] resultInArray = list2.ToArray();
            return resultInArray;
        }

        //CS Dojo's solution
        public static int[] commonElements2(int[] array1, int[] array2)
        {
            // initialize a pointer for each array (p1 for array1, p2 for array2)
            int p1 = 0;
            int p2 = 0;

            // initialize an empty list to hold result
            List<int> list = new List<int>();

            // while we still have values left in the arrays, compare the values and move the pointers
            while (p1 < array1.Length && p2 < array2.Length)
            {
                if (array1[p1] == array2[p2])
                {
                    list.Add(array1[p1]);
                    p1++;
                    p2++;
                }
                else if (array1[p1] > array2[p2])
                {
                    p2++;
                }
                else
                {
                    p1++;
                }
            }
            int[] resultInArray = list.ToArray();
            return resultInArray;
        }
    }
}
