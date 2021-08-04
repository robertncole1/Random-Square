using System;
using System.Collections.Generic;

namespace Random_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumber = new List<int>();

            for (int i = 1; i < 10; i++)
            {
                randomNumber.Add(random.Next(50));
            }
            foreach (var number in randomNumber)
            {
                Console.WriteLine($"Number: {number}");
            }

            var squaredNumberList = new List<int>();

            foreach (var number in randomNumber)
            {
                var squaredNumber = number * number;
                squaredNumberList.Add(squaredNumber);
                Console.WriteLine($"Squared number: {squaredNumber}");
            }

            squaredNumberList.RemoveAll(number => number % 2 != 0);

            foreach (var number in squaredNumberList)
            {
                Console.WriteLine($"Even number: { number}");

            }
        }
    }
}
