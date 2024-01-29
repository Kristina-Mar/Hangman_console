using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_console
{
    internal class WordsToBeGuessed
    {
        public static string category = string.Empty;
        public static string[] animals = { "ORANGUTAN", "ELEPHANT", "CROCODILE", "PLATYPUS", "BUTTERFLY", "GIRAFFE", "ANTEATER", "PENGUIN", "ANGLERFISH", "SEAHORSE", "CHEETAH", "MOSQUITO", "ALPACA", "CHICKEN", "BUFFALO", "PEACOCK" };
        public static string[] countries = { "TAJIKISTAN", "PARAGUAY", "BULGARIA", "INDONESIA", "LITHUANIA", "ARGENTINA", "MONGOLIA", "AZERBAIJAN", "SINGAPORE", "BAHRAIN", "LESOTHO", "MOZAMBIQUE", "TANZANIA", "ETHIOPIA", "BOTSWANA", "GUATEMALA" };
        public static string[][] allWords = { animals, countries };
        public static string chosenWord = string.Empty;
        private static Random randomNumberGenerator = new Random();
        public static void PickAWord()
        {
            int arrayNumber = randomNumberGenerator.Next(allWords.Length);
            int wordNumber = randomNumberGenerator.Next(allWords[arrayNumber].Length);
            chosenWord = allWords[arrayNumber][wordNumber];
            switch (arrayNumber)
            {
                case 0: category = "animal";
                    break;
                case 1:
                    category = "country";
                    break;
                default:
                    break;
            }
        }
    }
}
