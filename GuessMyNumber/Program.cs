using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shall we play a game?");
            string gameResponse = Console.ReadLine().ToUpper();

            if (gameResponse == "NO")
            {
                Console.WriteLine("Okay, Have a nice day.");
            }
            else
            {
                Console.WriteLine("What is the range of numbers would like to guess from?  ");
                int maxhNumber = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int secretNumber = rnd.Next(1, maxhNumber + 1);
                int userGuess = 0;
                int numberOfGuesses = 0;

                while (userGuess != secretNumber)
                {
                    Console.Write("What is your first guess?  ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses++;

                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Too low, try again.");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Too high, try again.");
                    }
                    else
                    {
                        Console.WriteLine("Great guess, you win!");
                        Console.WriteLine($"It took you {numberOfGuesses} guesses!");
                    }
                }
            }
        }
    }
}
