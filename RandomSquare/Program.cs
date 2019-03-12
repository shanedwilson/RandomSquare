using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var numbers = new List<int>();
            var sqNumbers = new List<int>();
            var finalNumbers = new List<int>();

            for(int i = 1; i <= 20; i++)
            {
                int randNum = random.Next(1,51);     // creates a number between 0 and 51
                numbers.Add(randNum * randNum);
            }

            //foreach(int number in numbers)
            //{
            //    int sqNumber = number * number;
            //    sqNumbers.Add(sqNumber);
            //}

            //foreach(int number in sqNumbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        finalNumbers.Add(number);
            //    }
            //}

            numbers.RemoveAll(i => i % 2 != 0);

            Console.WriteLine($"There are now {numbers.Count} numbers in the squared numbers list.");

            for(int i = 1; i < numbers.Count; i++)
            {
                Console.WriteLine($"Number {i} is {numbers[i]}");
            }
            Console.ReadKey();
        }
    }
}
