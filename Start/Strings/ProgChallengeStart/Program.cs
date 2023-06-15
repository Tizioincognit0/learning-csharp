using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            string inputNumStr = "";
            int targetNum = 0;
            int guesses = 0;
            bool keepGoing = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            Console.WriteLine("What's your guess?");
            do
            {
                inputNumStr = Console.ReadLine();
                if ("-1".Equals(inputNumStr))
                {
                    Console.WriteLine($"Oh well. I was thinking of {theNumber}");
                    keepGoing = false;
                }
                else
                {

                    if (!Int32.TryParse(inputNumStr, out targetNum))
                    {
                        Console.WriteLine("Hmmm, that doesn't look like a number. Try again");
                    }
                    else
                    {
                        guesses++;
                        if (targetNum == theNumber)
                        {
                            Console.WriteLine($"You got it in {guesses} guesses!!");
                            break;
                        }
                        else
                        {
                            if (targetNum < theNumber)
                            {
                                Console.WriteLine("Nope, higher than that.");
                            }
                            else
                            {
                                Console.WriteLine("Nope, lower than that.");
                            }
                        }
                    }
                }
            } while (keepGoing);

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer

        }
    }
}
