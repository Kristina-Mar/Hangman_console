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
            WordsToBeGuessed newWord = new WordsToBeGuessed();
            newWord.PickAWord();
            Player player = new Player();
            Console.Write($"Guess the {newWord.Category}: ");
            WordGuessing wordGuessing = new WordGuessing(newWord.ChosenWord);
            Console.Write(wordGuessing.UncoveredGuessedWord); // Writes out the word in underscores.
            Console.WriteLine();
            while (player.IsAlive())
            {
                player.LetterGuess();
                if (!wordGuessing.DoesWordIncludeGuessedLetter(player.GuessedLetter))
                {
                    player.NumberOfWrongGuesses++;
                }
                Console.WriteLine(wordGuessing.UncoveredGuessedWord);
                if (wordGuessing.IsWordGuessed())
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
