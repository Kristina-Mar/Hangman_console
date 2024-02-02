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
        public string Category = string.Empty;
        private string[] animals = { "ORANGUTAN", "ELEPHANT", "CROCODILE", "PLATYPUS", "BUTTERFLY", "GIRAFFE", "ANTEATER", "PENGUIN", "ANGLERFISH", "SEAHORSE", "CHEETAH", "MOSQUITO", "ALPACA", "CHICKEN", "BUFFALO", "PEACOCK" };
        private string[] countries = { "TAJIKISTAN", "PARAGUAY", "BULGARIA", "INDONESIA", "LITHUANIA", "ARGENTINA", "MONGOLIA", "AZERBAIJAN", "SINGAPORE", "BAHRAIN", "LESOTHO", "MOZAMBIQUE", "TANZANIA", "ETHIOPIA", "BOTSWANA", "GUATEMALA" };
        private string[] fruitNVeg = { "BROCCOLI", "CAULIFLOWER", "ZUCCHINI", "WATERMELON", "RASPBERRY", "LYCHEE", "GRAPEFRUIT", "PARSNIP", "ARTICHOKE", "BEETROOT", "SPINACH", "NECTARINE", "WATERCRESS", "¨BLACKCURRANT", "PASSIONFRUIT", "JACKFRUIT" };
        public string ChosenWord = string.Empty;
        private Random randomNumberGenerator = new Random();
        public void PickAWord()
        {
            string[][] allWords = { animals, countries, fruitNVeg };
            int arrayNumber = randomNumberGenerator.Next(allWords.Length);
            int wordNumber = randomNumberGenerator.Next(allWords[arrayNumber].Length);
            ChosenWord = allWords[arrayNumber][wordNumber];
            switch (arrayNumber)
            {
                case 0: Category = "animal";
                    break;
                case 1:
                    Category = "country";
                    break;
                case 2:
                    Category = "fruit or vegetable";
                    break;
                default:
                    break;
            }
        }
    }
}
