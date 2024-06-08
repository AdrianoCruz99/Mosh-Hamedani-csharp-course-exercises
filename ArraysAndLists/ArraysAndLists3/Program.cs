using System.Collections.Generic;
using System;
using System.Linq;

namespace ArraysAndLists3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            List<int> numbers = new List<int>();

            Console.WriteLine("Type five different numbers: ");


            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("This number is already on the list! Try again.");
                    i--;
                }
                else
                    numbers.Add(number);
            }

            numbers = numbers.OrderBy(x => Guid.NewGuid()).ToList();
            Console.WriteLine("Sorted numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

    }
}
