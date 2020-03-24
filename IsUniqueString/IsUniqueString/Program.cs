using System;
using System.Collections.Generic;

namespace IsUniqueString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("giraffe"));
            Console.WriteLine(IsUnique("golf"));
            Console.WriteLine(IsUnique("a"));
            Console.WriteLine(IsUnique("function"));
            Console.WriteLine(IsUnique("fox jumps in"));
            
        }

        // QUESTION: implement an algorithm to determine if a string has all unique characters

        // INPUT: string s of any length
        // OUTPUT: bool; true if all unique characters
        // ASSUMPTIONS: string can be any length
        // CONSTRAINTS: can't use any kind of .Equals function
        // SAMPLE INPUTS:
        // "giraffe" returns false
        // "golf" returns true
        // "a" returns true
        // "function" returns false
        // what about spaces or punctuation? i.e. "fox jumps in" returns true?

        public static bool IsUnique(string s)
        {
            // iterate through the input string
            // save unique chars in a dictionary with a counter as the value
            // if we come across a char that we've seen before, exit the loop and return false
            // otherwise return true

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else if (c == ' ')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        // what if you can't use additional data structures?
        // use bit vectors - need to research this further and come back to it
    }
}
