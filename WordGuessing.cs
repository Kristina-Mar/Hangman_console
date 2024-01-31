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
        private char[] GuessedWord;
        public char[] UncoveredGuessedWord;
        public WordGuessing(string newWord)
        {
            GuessedWord = newWord.ToCharArray();
            UncoveredGuessedWord = new char[GuessedWord.Length];
        }

        public void ShowGuessedWordUnderscores()
        {
            for (int i = 0; i < GuessedWord.Length; i++)
            // The program first writes out the guessed word in underscores - the player knows the word length.
            {
                UncoveredGuessedWord[i] = '_';
            }
        }
        public bool DoesWordIncludeGuessedLetter (char guessedLetter)
        {
            if (GuessedWord.Contains(guessedLetter))
            {
                for (int i = 0; i < GuessedWord.Length; i++)
                {
                    if (GuessedWord[i] == guessedLetter) // Replaces the underscore with the correctly guessed letter.
                    {
                        UncoveredGuessedWord[i] = guessedLetter;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
