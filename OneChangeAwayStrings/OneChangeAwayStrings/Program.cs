using System;

namespace OneChangeAwayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOneAway("abcde", "abcd"));  // should return true
            Console.WriteLine(IsOneAway("abde", "abcde"));  // should return true
            Console.WriteLine(IsOneAway("a", "a"));  // should return true
            Console.WriteLine(IsOneAway("abcdef", "abqdef"));  // should return true
            Console.WriteLine(IsOneAway("abcdef", "abccef"));  // should return true
            Console.WriteLine(IsOneAway("abcdef", "abcde"));  // should return true
            Console.WriteLine(IsOneAway("aaa", "abc"));  // should return false
            Console.WriteLine(IsOneAway("abcde", "abc"));  // should return false
            Console.WriteLine(IsOneAway("abc", "abcde"));  // should return false
            Console.WriteLine(IsOneAway("abc", "bcc"));  // should return false
        }

        // My solution
        // input: two strings
        // output: bool value (checks if two strings are one change away from being the same string)
        // assumptions: two strings that are already the same return true with this function
        // deletions and additions also can create two same strings
        // try to solve in O(n) time

        // thoughts:
        // 1. check if two strings are the same and automatically return true
        // 2. check if the difference between the two string lengths is > 1; return false for >1 difference
        // 3. use two pointers to iterate through the two strings and check the chars at each index
            // 3a. if chars are the same, continue
            // 3b. if chars differ, try replacing the char in one string
        // 4. continue through the rest of the strings, comparing each char
            // 4a. if this comparison is true at the end, return true
            // 4b. if this comparison fails at any point, break and return false

        public static bool IsOneAway(string s1, string s2)
        {
            // check if two strings are the same
            // first if statement is the shortest way to check if strings are exactly the same, though this may be a constraint in an interview
            // third if statement will cover this condition if we get rid of the .equals

            //if (s1.Equals(s2))
            //{
            //    return true;
            //}

            // check if difference between string sizes is more than 1; if it is, return false
            // could use absolute value math function instead of ||; I'm assuming this is a constraint
            if (s1.Length - s2.Length > 1 || s2.Length - s1.Length > 1)
            {
                return false;
            }

            // if lengths are the same, check to see how many chars are different between the two strings with SameLength function
            else if (s1.Length == s2.Length)
            {
                return SameLength(s1, s2);
            }

            // if lengths are within one of each other, call DiffLength function
            // if s1 is longer, put s1 first in parameters
            // if s2 is longer, put s2 first in parameters
            else if (s1.Length > s2.Length)
            {
                return DiffLengths(s1, s2);
            }
            else
            {
                return DiffLengths(s2, s1);
            }
        }

        public static bool SameLength(string s1, string s2)
        {
            int wrongCount = 0;

            // loop through the array and find where they don't match
            for (int i = 0; i < s1.Length; i++)
            {
                // count how many chars are not equal in the two strings
                if (s1[i] != s2[i])
                {
                    wrongCount++;
                }
                if (wrongCount > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool DiffLengths(string s1, string s2)
        {
            int missingCount = 0;
            int i = 0;
            while (i < s2.Length)
            {
                if (s1[i + missingCount] == s2[i])
                {
                    i++;
                }
                else
                {
                    missingCount++;
                    if (missingCount > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }

}

