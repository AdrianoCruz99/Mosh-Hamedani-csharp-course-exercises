using System.Collections.Generic;
using System;
using System.Linq;

namespace ArraysAndLists4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates.
            //Display the unique numbers that the user has entered.

            
            List<int> numbers = new List<int>();
            while (true)
            {
                int number;
                Console.WriteLine("Type a number or press any other key to exit: ");
                string input = Console.ReadLine();
                
                if(int.TryParse(input, out number))
                {
                    if(!numbers.Contains(number))
                    numbers.Add(number);
                    
                }
                else
                    break;
            }
            Console.WriteLine("Your numbers: ");
            foreach(int number in numbers )
            {
                Console.WriteLine(number);
            }
        }
    }
}
