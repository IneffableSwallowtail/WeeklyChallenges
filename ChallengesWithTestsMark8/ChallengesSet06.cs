using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool contains = false;

            if (ignoreCase == true)
            {
                foreach (string w in words)
                {
                    string lowercaseWord = w.ToLower();
                    if (lowercaseWord == word.ToLower()) contains = true;
                }
            }
            else
            {
                foreach (string w in words)
                {
                    if (w == word) contains = true;
                }
            }
            return contains;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrime = false;
            for (int i = 2; i < num && !isPrime; i++)
            {
                isPrime = (num % i == 0) ? true : false;
            }
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool unique = false;
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            bool isLetter(char c)
            {
                if (alpha.Contains(c) || alpha.ToUpper().Contains(c)) return true;
                else return false;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (isLetter(str[i]) == false) continue;

                for (int x = str.Length - 1; i >= 0; i--)
                {
                    if (i == x) continue;
                    else if (str[i] == str[x])
                    {
                        unique = true;
                        index = i;
                        break;
                    }

                }
                if (unique == true) index = i;
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 1;
                int x = i;
                while (true)
                {
                    if (numbers[x] == numbers[++x]) count++;
                    else break;
                }
                if (count > maxCount) maxCount = count;
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] nthElements = new double[elements.Count / n];
            int index = 0;

            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElements[index++] = elements[i];
            }
            return nthElements;
        }
    }
}
