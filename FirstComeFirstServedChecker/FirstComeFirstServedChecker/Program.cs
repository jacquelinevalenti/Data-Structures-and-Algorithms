using System;

namespace FirstComeFirstServedChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // given three arrays, check if orders are being served first-come first-served

            // for example: the following returns false
            // Take Out Orders: [1, 3, 5]
            // Dine In Orders: [2, 4, 6]
            // Served Orders: [1, 2, 4, 6, 5, 3]

            // the following returns true:
            // Take Out Orders: [1, 3, 5]
            // Dine In Orders: [2, 4, 6]
            // Served Orders: [1, 2, 3, 5, 4, 6]

            int[] takeout = new int[] { 1, 3, 5 };
            int[] dinein = new int[] { 2, 4, 6 };
            int[] served = new int[] { 1, 2, 3, 5, 4, 6 };
            Console.WriteLine(FCFSCheck(takeout, dinein, served));
        }

        // inputs: three arrays
        // output: bool (FCFS or not)
        // steps: 
        // 1. initialize three pointers (one for each array)
        // 2. compare first index of servedorders to first indicies of takeout and dinein
            // 2a. if servedorders isn't equal to either takeout or dineine, return false
            // 2b. otherwise, move the pointer for the array with the matching value and move the pointer for servedorders
        // 3. repeat step 2 until we've gone through both takeout and dinein completely
            // when you reach the end of one of the arrays, exit the loop and do some check for the rest of the values in the array
        // 4. if you get to the end, return true!

        public static bool FCFSCheck(int[] takeOut, int[] dineIn, int[] served)
        {
            int T = 0;
            int D = 0;
            int S = 0;

            while (T < takeOut.Length && D < dineIn.Length)
            {
                if (served[S] != takeOut[T] && served[S] != dineIn[D])
                {
                    return false;
                }

                else if (served[S] == takeOut[T])
                {
                    T++;
                }
                else
                {
                    D++;
                }
                S++;
            }

            while (T < takeOut.Length)
            {
                if (served[S] != takeOut[T])
                {
                    return false;
                }
                T++;
                S++;
            }

            while (D < takeOut.Length)
            {
                if (served[S] != dineIn[D])
                {
                    return false;
                }
                D++;
                S++;
            }
            return true;
        }
    }
}
