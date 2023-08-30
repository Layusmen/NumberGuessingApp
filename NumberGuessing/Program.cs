using System;
namespace numberguessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator.
            Random rng = new Random();

            // Generate a random number between 0 and 100.
            int randomNumber = rng.Next(0, 100);

            // Print the random number.
            //Console.WriteLine(randomNumber);
            Console.WriteLine("App to guess a secret random number made between 0 and 100");



            // Initialize the number of guesses.
            int guesses = 0;

            // Giving User Opportunity to make 5 guesses.
            int highestGuesses = 5;

            // Loop over the 5 guesses.
            for (int i = 0; i < highestGuesses; i++)
            {
                // user guess.

                Console.WriteLine("Please put a number between 0 and 100");
                int numGuess = int.Parse(Console.ReadLine());

                // Increment the number of guesses.
                guesses++;

                // Check if the guess is correct.
                if (numGuess == randomNumber)
                {
                    // The user guessed the correct number!
                    Console.WriteLine("Congratulations! You guessed the number in {0} guesses.", guesses);
                    break;
                }
                else if (numGuess < randomNumber)
                {
                    // The guess is too low.
                    Console.WriteLine("Too Low!. You have {0} guesses left.", highestGuesses - guesses);
                }
                else
                {
                    // The guess is too high.
                    Console.WriteLine("Too High!. You have {0} guesses left.", highestGuesses - guesses);
                }
                // If the user ran out of guesses, tell them they lost and print the Random number.
                if (guesses == highestGuesses)
                {
                    Console.WriteLine("You lost! The Random number was {0}.", randomNumber);
                }



            }
        }
    }
}
