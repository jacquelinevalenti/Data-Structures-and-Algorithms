using System;
using System.Collections.Generic;

namespace NonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: The following input values will be used for testing your solution.
            char result1 = nonRepeating("abcab"); // should return 'c'
            char result2 = nonRepeating("abab"); // should return null
            char result3 = nonRepeating("aabbbc"); // should return 'c'
            char result4 = nonRepeating("aabbdbc"); // should return 'd'

            Console.WriteLine("If char returned is '?', there is no non-repeating character in the string.");
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }

        // My solution (also CS Dojo's solution! yay!)
        // input: string
        // output: char that only occurs once in string
        // assumptions: string is of variable length, may or may not be repeats, not necessarily "sorted"
        // constraints: try to solve in O(n)
        // 1. loop through each char in the string
        // 2. for each unique char, add to a dictionary and make the count 1
        // 3. for each non-unique char, increment the counter in dictionary
        // 4. check which char has the largest counter value and return that char
        public static char nonRepeating(string s)
        {
            char singleChar = '?';
            Dictionary<char, int> dict = new Dictionary<char, int>();
            // iterate through string and count occurances of each char by storing in a dictionary
            foreach (char c in s)
            {
                // if not in the dictionary yet, add it with a value of 1
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                // otherwise increment the value
                else
                {
                    dict[c] += 1;
                }
            }
            // iterate through string again and check if any items in dictionary only occur once
            // if they do, assign singleChar and exit the loop
            // otherwise loop will run and singlechar will return as null
            foreach (char c in s)
            {
                if (dict[c] == 1)
                {
                    singleChar = c;
                    break;
                }
            }
            return singleChar;
        }
    }
}
