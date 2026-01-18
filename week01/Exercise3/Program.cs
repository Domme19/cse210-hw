using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
       
        string keepOnPlaying = "yes";

        // while loop
        while (keepOnPlaying == "yes")
        {
             // Guessing Number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.WriteLine($"The current magic number: {magicNumber}");

            int guess = -1;
            int guessCount = 0;

             while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                    guessCount += 1;
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                    guessCount += 1;
                }
                else
                {
                    Console.WriteLine($"You guessed it with {guessCount} guesses!");
                    Console.Write("Would you want to play again (Yes/No)?");
                    keepOnPlaying = Console.ReadLine().ToLower().Trim();
                }
            }
        }
       

    }
}