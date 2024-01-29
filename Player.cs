using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_console
{
    internal class Player
    {
        public static int MaxNumberOfWrongGuesses = 8;
        public static int NumberOfWrongGuesses = 0;
        private static string GuessedLettersString = string.Empty;
        public static char[] GuessedLetters = GuessedLettersString.ToCharArray();
        public static char GuessedLetter = '_';
        public static char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static void LetterGuess()
        {
            GuessedLetter = '_';
            Console.WriteLine("Guess a letter.");
            GuessedLetter = Char.ToUpper(Console.ReadKey().KeyChar);
            while (GuessedLetters.Contains(GuessedLetter) || !Alphabet.Contains(GuessedLetter))
            // The loop checks if the player guesses the same letter again and if the player guesses only letters of the alphabet.
            {
                Console.WriteLine();
                Console.WriteLine($"Guess again.");
                GuessedLetter = Char.ToUpper(Console.ReadKey().KeyChar);
            }
                GuessedLettersString += GuessedLetter;
                GuessedLetters = GuessedLettersString.ToCharArray();
                Console.WriteLine();
                Console.WriteLine($"Guessed letters: {String.Join(", ",GuessedLetters)}"); // Writes out the letters the player has already guessed.
        }
    }
}
