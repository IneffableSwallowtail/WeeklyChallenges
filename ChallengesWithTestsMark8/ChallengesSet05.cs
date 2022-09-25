using System;
using System.Collections.Generic;
using System.Reflection;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            bool cont = true;
            int nextDividend = 0;
            for (int i = startNumber + 1; cont == true; i++)
            {
                if (i % n == 0)
                {
                    nextDividend = i;
                    cont = false;
                }
            }
            return nextDividend;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business company in businesses)
                if (company.TotalRevenue == 0) company.Name = "CLOSED";
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool ascending = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                ascending = (ascending && (numbers[i] <= numbers[i + 1]));
            }
            return ascending;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0) sum += numbers[i + 1];
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                sentence += $"{words[i]} ";
            }
            sentence += $"{words[words.Length - 1]}.";
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] fourthElements = new double[elements.Count / 4];
            int count = 0;

            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElements[count++] = elements[i];
            }
            return fourthElements;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool canSum = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 0; i < nums.Length; i++)
                {
                    if (x == i)
                    {
                        continue;
                    }
                    else if (nums[i] + nums[x] == targetNumber)
                    {
                        canSum = true;
                    }
                }
            }
            return canSum;
        }
    }
}
