using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return alphabet.Contains(Char.ToLower(c)) ? true : false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Count() % 2 == 0) ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) return 0;
            double minimum = numbers.Min();
            double maximum = numbers.Max();
            return minimum + maximum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = (number % 2 == 0) ? sum + number : sum;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (sum % 2 != 0) ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if ((number > 0) && (number % 2 == 0))
                return number / 2;
            else if ((number > 0) && number % 2 != 0)
                return (number - 1) / 2;
            else
                return 0;
        }
    }
}
