using System;
using System.Collections;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to be reversed: ");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);
            Console.WriteLine(reversed);

        }

        // write a method that takes an array of characters and reverses the letters in place
        // manipulate the strings in place (modify the input; don't make a copy)
        // INPUT: string
        // OUTPUT: reversed string
        // ASSUMPTIONS: string can be any length
        // CONSTRAINTS: don't use reverse
        // steps:
        // 1. convert the input to a char array
        // 2. add each char to a stack (since we want to reverse it in place)
        // 3. pop each char off the stack and return

        public static string ReverseString(string s)
        {
            char[] reversedarray = new char[s.Length];

            Stack stack = new Stack();
            foreach (char c in s)
            {
                stack.Push(c);
            }
            for (int i = 0; i < s.Length; i++)
            {
                char rev = (char)stack.Pop();
                reversedarray[i] = rev;
            }
            string reversed = new string(reversedarray);
            return reversed;
           
        }

        // alternate way
        public static void Reverse2(char[] array)
        {
            int leftindex = 0;
            int rightindex = array.Length - 1;

            while (rightindex > leftindex)
            {
                char temp = array[leftindex];
                array[leftindex] = array[rightindex];
                array[rightindex] = temp;

                rightindex--;
                leftindex++;
            }
        }
    }
}
