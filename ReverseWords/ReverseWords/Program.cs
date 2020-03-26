using System;
using System.Collections.Generic;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'i', 's', ' ', 'n', 'a', 'm', 'e', ' ', 'm', 'y' };
            //ReverseWords(arr);
            //foreach (char c in arr)
            //{
            //    Console.Write(c);
            //}

            Console.WriteLine(ReverseAgain(arr));

        }

        // given a char array of words, reverse the words (not the letters)
        // example: {'i' 's' ' ' 'n' 'a' 'm' 'e' ' ' 'm' 'y'}
        // output: "my name is"

        // steps:
        // 1. loop through the char array, save the chars in order
        // 2. stop when you find a space
        // 3. repeat that process through the array
        // 4. convert to a string and print


        public static string ReverseAgain(char[] arr)
        {
            string result = string.Empty;
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == arr.Length)
                {
                    stack.Push(result);
                    result = string.Empty;
                }
                else if (arr[i] == ' ')
                {
                    result = string.Concat(result, arr[i]);
                    stack.Push(result);
                    result = string.Empty;
                }
                else
                {
                    result = string.Concat(result, arr[i]);
                }
            }
            {
                
            }
            foreach (var item in stack)
            {
                result += string.Concat(item);
            }
            return result;
        }

        public static void ReverseWords(char[] arr)
        {
            // reverse all characters
            ReverseCharacters(arr, 0, arr.Length - 1);

            int wordIndex = 0;
            // then reverse the characters within each word
            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == arr.Length || arr[i] == ' ')
                {
                    ReverseCharacters(arr, wordIndex, i - 1);
                    wordIndex = i + 1;
                }
            }
        }

        public static void ReverseCharacters(char[] arr, int left, int right)
        {
            // helper method to reverse all characters in a given array

            while (right > left)
            {
                char temp = arr[right];
                arr[right] = arr[left];
                arr[left] = temp;

                right--;
                left++;
            }
        }
    }
}
