using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_console
{
    internal class Game
    {
        public static void StartGame()
        {
            WordsToBeGuessed.PickAWord();
            Console.Write($"Guess the {WordsToBeGuessed.category}: ");
            for (int i = 0; i < WordGuessing.GuessedWord.Length; i++)
            // The program first writes out the guessed word in underscores - the player knows the word length.
            {
                WordGuessing.UncoveredGuessedWord[i] = '_';
            }
            Console.Write(WordGuessing.UncoveredGuessedWord);
            Console.WriteLine();
            while (Player.NumberOfWrongGuesses < Player.MaxNumberOfWrongGuesses)
            {
                Player.LetterGuess();
                WordGuessing.UncoverGuessedWord(Player.GuessedLetter);
                if (!WordGuessing.UncoveredGuessedWord.Contains('_'))
                // When all the undersocres are replaced with correctly guessed letters, the game is won.
                {
                    Console.WriteLine("You win!");
                    return;
                }
            }
            Console.WriteLine("Game over."); // When the player uses up their incorrect guesses, the game is over.
            return;
        }
    }
}
