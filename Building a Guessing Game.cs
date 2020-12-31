using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = ""; //Storing what the user enters/guesses into this variable
            int guessCount = 0; //Adding a 'guessCount' variable to keep track of how many times the user has guessed.
            int guessLimit = 3; //Adding a 'guesLimit' variable so we need to tell the program the max amount of times the user can guess.
            bool outOfGuesses = false; //This 'outOfGuesses' variable will tell us whether or not the user is out of guesses.

            while (guess != secretWord && !outOfGuesses) //Allow the user to keep guessing while they havent guessed the 'secretWord' & they're not out of guesses. Otherwise break out of the loop.
            {
                if (guessCount < guessLimit) //Only allow the user to guess when they still have guesses left (if they havent guessed 3 times already)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++; //Increment the value in the 'guessCount' variable by 1 each time the user has guessed.
                }
                else
                {
                    outOfGuesses = true; //If the user doesnt have any guesses left chnage the value of the 'outOfGuess' to true which triggers to break out the loop.
                }

            }
            if (outOfGuesses) //When we break out the loop theres two situations
            {
                Console.Write("You Lose!"); //One situation is where we guessed the 'secretWord' incorrectly for all 3 attempts.
            }
            else
            {
                Console.Write("You Win!"); //Another situation is where we guessed the 'secretWord' correctly within the 3 attempts.
            }

            Console.ReadLine();
        }
    }
}
