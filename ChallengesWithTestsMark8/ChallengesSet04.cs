using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0) evens.Add(number);
                else odds.Add(number);
            }
            foreach (int number in evens) sum += number;
            foreach (int number in odds) sum -= number;
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int min1 = Math.Min(str1.Length, str2.Length);
            int min2 = Math.Min(str3.Length, str4.Length);
            return (min1 < min2) ? min1 : min2;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int min1 = Math.Min(number1, number2);
            int min2 = Math.Min(number3, number4);
            return (min1 < min2) ? min1 : min2;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 ||
                sideLength2 + sideLength3 <= sideLength1 ||
                sideLength3 + sideLength1 <= sideLength2)
                return false;
            else
                return true;
        }

        public bool IsStringANumber(string input)
        {
            return Int32.TryParse(input, out int result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int valueCount = 0;

            foreach (var obj in objs)
            {
                if (obj == null) nullCount++;
                else valueCount++;
            }
            return (nullCount > valueCount);
        }

        public double AverageEvens(int[] numbers)
        {
            int sum = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            }
            return sum / count;
        }

        public int Factorial(int number)
        {
            int product = 1;
            for (int i = number; i > 0; i--)
            {
                product *= i;
            }
            return product;
        }
    }
}
