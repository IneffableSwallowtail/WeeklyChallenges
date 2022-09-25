using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "0123456789";

        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool contains = false;
            foreach (bool val in vals)
            {
                if (val == false)
                {
                    contains = true;
                }
            }
            return contains;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            List<int> odds = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 != 0) odds.Add(number);
            }
            return (odds.Count % 2 != 0) ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;
            foreach (char c in password)
            {
                if (alphabet.ToUpper().Contains(c) == true) containsUpper = true;
                else if (alphabet.Contains(c) == true) containsLower = true;
                else if (numbers.Contains(c) == true) containsNumber = true;
            }
            return containsUpper && containsLower && containsNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            char firstLetter = 'a';
            bool cont = true;
            for (int i = 0; cont == true; i++)
            {
                if (alphabet.Contains(val[i]) || alphabet.ToUpper().Contains(val[i]))
                {
                    firstLetter = val[i];
                    cont = false;
                }
            }
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = 'z';
            bool cont = true;
            for (int i = val.Length - 1; cont == true; i--)
            {
                if (alphabet.Contains(val[i]) || alphabet.ToUpper().Contains(val[i]))
                {
                    lastLetter = val[i];
                    cont = false;
                }
            }
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums[nums.Length - 1] - nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            for (int i = 0; i < odds.Length; i++)
            {
                odds.SetValue(2 * i + 1, i);
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
