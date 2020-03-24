using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the lower bound?");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the upper bound?");
            int upper = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int rand = random.Next(lower, upper);

            Console.WriteLine("What is your first guess?");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == rand)
            {
                Console.WriteLine("You got it!");
            }
            else
            {
                
            }

        }

        
    }
}
