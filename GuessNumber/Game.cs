using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    class Game : IGame
    {
        public void Run()
        {
            int userInput = 0;
            bool askForInput = true;
            bool guessIsRight = false;
            int programNumber = 0;

            var getRandomNumber = new Random();
            programNumber = getRandomNumber.Next(0, 100);

            Console.WriteLine("Guess the number between 0 and 100");
            while (askForInput)
            {
                while (askForInput)
                {
                    Int32.TryParse(Console.ReadLine(), out userInput);
                    if (userInput >= 0 & userInput <= 100)
                    {
                        askForInput = false;
                    }
                }

                    if (userInput < programNumber)
                    {
                        Console.WriteLine("My number is higher, try again");

                    }
                    else
                    { }
            }
            Console.WriteLine($"Your gess is {userInput}");
            
        }
    }
}
