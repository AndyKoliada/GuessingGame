using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class Game : IGame
    {
        public void Run()
        {
            Random r = new Random();

            int val = r.Next(1, 100);
            int guess;
            bool correct = false;

            Console.WriteLine("Guess a number between 1 and 100.");

            while (!correct)
            {
                Console.Write("Your guess is  ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess < val)
                {
                    Console.WriteLine($"My number is higher than {guess}.");
                }
                else if (guess > val)
                {
                    Console.WriteLine($"My number is lower than {guess}.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Congrats! You guessed right!");
                }
            }
        }
    }
}
