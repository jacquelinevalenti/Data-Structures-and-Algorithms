using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(4, "a", "c", "b");
            Console.WriteLine(CountSteps(2));
        }

        // write a method that moves n number of disks from one pole to another using an intermediate pole
        // calculate the number of moves it takes to move n disks
        static void Hanoi(int numDisks, string start, string end, string middle)
        {
            // when n is 1, just move the disk from the start to the end
            if (numDisks == 1)
            {
                Console.WriteLine($"Move disk {numDisks} from pole {start} to pole {end}.");
            }
            // for n-1 disks above the bottom disk, move disk from start to middle, middle to end
            // recursively call hanoi function with different inputs to acheive this
            else
            {
                Hanoi(numDisks - 1, start, middle, end);
                Console.WriteLine($"Move disk {numDisks} from pole {start} to pole {end}.");
                Hanoi(numDisks - 1, middle, end, start);
            }
        }

        static int CountSteps(int numDisks)
        {
            // 1 disk takes one move
            // 2 disks takes 3 moves
            // 3 disks takes 7 moves
            // formula = (previousSteps * 2) + 1
            if (numDisks == 1)
            {
                return numDisks;
            }
            else
            {
                int totalSteps = (CountSteps(numDisks - 1) * 2) + 1;
                return totalSteps;
            }
            
        }
    }
}
