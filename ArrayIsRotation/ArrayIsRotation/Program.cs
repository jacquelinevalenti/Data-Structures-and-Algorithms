using System;
using System.Collections;

namespace ArrayIsRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] array2a = { 4, 5, 6, 7, 8, 1, 2, 3 };
            // isRotation(array1, array2a) should return false.
            int[] array2b = { 4, 5, 6, 7, 1, 2, 3 };
            // isRotation(array1, array2b) should return true.
            int[] array2c = { 4, 5, 6, 9, 1, 2, 3 };
            // isRotation(array1, array2c) should return false.
            int[] array2d = { 4, 6, 5, 7, 1, 2, 3 };
            // isRotation(array1, array2d) should return false.
            int[] array2e = { 4, 5, 6, 7, 0, 2, 3 };
            // isRotation(array1, array2e) should return false.
            int[] array2f = { 1, 2, 3, 4, 5, 6, 7 };
            // isRotation(array1, array2f) should return true.

            Console.WriteLine(isRotation(array1, array2b));
        }

        // assumptions: not necessarily sorted; no duplicates
        // input: 2 int arrays
        // output: bool
        // need to solve in O(n) time

        // initial thoughts: order matters; need to keep track of both value and index
        // maybe add the first array to a queue, then dequeue them and compare to second array?
        // or: use two pointers to compare values between the two arrays
            // start with first index in first array, then loop through second array to see if/where it exists, then loop through both arrays simultaneously to check if all values are the same

        public static bool isRotation(int[] array1, int[] array2)
        {
            // CS Dojo's solution
            // check if two arrays are the same length; if not then return false
            if (array1.Length != array2.Length)
            {
                return false;
            }

            int key = array1[0];
            int index = -1;

            // search for array1's 0 index in array2
            // save that location in array2
            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] == key)
                {
                    index = i;
                    break;
                }
            }
            // if array1's 0 index isn't in array2, return false
            if (index == -1)
            {
                return false;
            }
            // loop through array1
            for (int i = 0; i < array1.Length; i++)
            {
                int j = (index + i) % array1.Length;
                if (array1[i] != array2[j])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
