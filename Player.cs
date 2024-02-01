using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangman_console
{
    internal class Player
    {
        public int MaxNumberOfWrongGuesses = 8;
        public int NumberOfWrongGuesses = 0;
        private string guessedLettersString = string.Empty;
        public char[] GuessedLetters = { };
        public char GuessedLetter = '_';
        public void LetterGuess()
        {
            GuessedLetters = guessedLettersString.ToCharArray();
            GuessedLetter = '_';
            Console.WriteLine("Guess a letter.");
            GuessedLetter = Char.ToUpper(Console.ReadKey().KeyChar);
            while (GuessedLetters.Contains(GuessedLetter) || !Regex.IsMatch(GuessedLetter.ToString(), "^[a-zA-Z]+$"))
            // The loop checks if the player guesses the same letter again and if the player guesses only letters of the alphabet.
            // The second condition only allows for letter in the English alphabet.
            {
                Console.WriteLine();
                Console.WriteLine($"Guess again.");
                GuessedLetter = Char.ToUpper(Console.ReadKey().KeyChar);
            }
                guessedLettersString += GuessedLetter;
                GuessedLetters = guessedLettersString.ToCharArray();
                Console.WriteLine();
                Console.WriteLine($"Guessed letters: {String.Join(", ",GuessedLetters)}"); // Writes out the letters the player has already guessed.
        }
    }
}
