using System;
namespace numberguessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator.
            Random rng = new Random();

            //Giving User Opportunity to make 5 guesses.
            const int HIGHEST_GUESSES = 5;

            //Constants for limit
            const int UPPER_LIMIT = 100;
            const int LOWER_LIMIT = 1;

            //constant for offset
            const int OFF_SET = 5;

            // Generate a random number between 0 and 100.
            int randomNumber = rng.Next(LOWER_LIMIT, UPPER_LIMIT+1);

            Console.WriteLine("App to guess a secret random number made between {0} and {1}", LOWER_LIMIT, UPPER_LIMIT);

            // Initialize the number of guesses.
            int guesses = 0;

            // Loop over the 5 guesses.
            for (int i = 0; i < HIGHEST_GUESSES; i++)
            {
                // user guess.
                Console.WriteLine("Please put a number between {0} and {1}", LOWER_LIMIT, UPPER_LIMIT);
                int numGuess = int.Parse(Console.ReadLine());

                // Check if the guess is correct.
                if (numGuess == randomNumber)
                {
                    // The user guessed the correct number!
                    Console.WriteLine("Congratulations! You guessed the number in {0} guesses.", guesses);
                    break;
                }
                else if (Math.Abs(numGuess - randomNumber) <= OFF_SET)
                {
                    // The guess is close to the secret number.
                    Console.WriteLine("You are close to the secret number!");
                }
                else if (numGuess < randomNumber)
                {
                    // The guess is too low.
                    Console.WriteLine("Too Low!. You have {0} guesses left.", HIGHEST_GUESSES - i - 1);
                }
                else
                {
                    // The guess is too high.
                    Console.WriteLine("Too High!. You have {0} guesses left.", HIGHEST_GUESSES - i - 1);
                }
            }
            // If the user ran out of guesses, tell them they lost and print the Random number.
            if (guesses == HIGHEST_GUESSES)
            {
                Console.WriteLine("You lost! The Random number was {0}.", randomNumber);
            }
        }
    }
}
