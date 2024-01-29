using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_console
{
    internal class WordGuessing
    {
        public static char[] GuessedWord = WordsToBeGuessed.chosenWord.ToCharArray();
        public static char[] UncoveredGuessedWord = new char[GuessedWord.Length];
        public static void UncoverGuessedWord (char guessedLetter)
        {
            if (GuessedWord.Contains(Player.GuessedLetter))
            {
                for (int i = 0; i < GuessedWord.Length; i++)
                {
                    if (GuessedWord[i] == guessedLetter) // Replaces the underscore with the correctly guessed letter.
                    {
                        UncoveredGuessedWord[i] = guessedLetter;
                    }
                }
            }
            else
            {
                Player.NumberOfWrongGuesses++;
            }
            Console.WriteLine(UncoveredGuessedWord);
        }
    }
}
