using System;

namespace OneChangeAwayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            isOneAway("abcde", "abcd");  // should return true
            isOneAway("abde", "abcde");  // should return true
            isOneAway("a", "a");  // should return true
            isOneAway("abcdef", "abqdef");  // should return true
            isOneAway("abcdef", "abccef");  // should return true
            isOneAway("abcdef", "abcde");  // should return true
            isOneAway("aaa", "abc");  // should return false
            isOneAway("abcde", "abc");  // should return false
            isOneAway("abc", "abcde");  // should return false
            isOneAway("abc", "bcc");  // should return false
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

        public static bool isOneAway(string s1, string s2)
        {
            // check if two strings are the same
            // first if statement is the shortest way, though this may be a constraint in an interview

            //if (s1.Equals(s2))
            //{
            //    return true;
            //}

            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        break;
                    }
                    
                  

                }
            }

            // check if difference between string sizes is more than 1; if it is, return false
            // could use absolute value math function instead of or statement; I'm assuming this is a constraint
            else if (s1.Length - s2.Length > 1 || s2.Length - s1.Length > 1)
            {
                return false;
            }

            // if lengths are within 1 of each other, try to make them the same string
            else
            {

            }
            
            
        }

    }

  
}

