﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_console
{
    internal class WordGuessing
    {
        public char[] GuessedWord;
        public char[] UncoveredGuessedWord;
        public WordGuessing(string newWord)
        {
            GuessedWord = newWord.ToCharArray();
            UncoveredGuessedWord = new char[GuessedWord.Length];
            for (int i = 0; i < GuessedWord.Length; i++)
            // The program first shows the guessed word in underscores - the player knows the word length.
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
        public bool IsWordGuessed()
        {
            if (UncoveredGuessedWord.Contains('_'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
