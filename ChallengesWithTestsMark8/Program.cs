using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static int[] nullEnumerable;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            var test = new ChallengesSet02(); 
            
            Console.WriteLine(test.Sum(nullEnumerable)); //it's null on purpose, are you telling me I gotta do a try catch on Challenge Set 02? D:
            //How bout we just ~not run a null value to the method~, how bout that?
        }
    }
}
