using System.Collections.Generic;

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string input;

            Console.WriteLine("Insert a name(press enter without type a name to close the program).");

            while (true)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                names.Add(input);
            }
            string message = GenerateLikeMessage(names);
            Console.WriteLine(message);
        }
        static string GenerateLikeMessage(List<string> names)
        {
            int count = names.Count;
            if (count == 0)
            {
                return ("");
            }
            else if (count == 1)
            {
                return ($"{names[0]} likes your post.");
            }
            else if (count == 2)
            {
                return ($"{names[0]} and {names[1]} likes your post.");
            }
            else
            {
                return ($"{names[0]}, {names[1]} and {count - 2} likes your post");
            }
        }
    }
}
