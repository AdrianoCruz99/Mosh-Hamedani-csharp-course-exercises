namespace ArraysAndLists5
{
    internal class Program
    {
        //Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the
        //list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise,
        //display the 3 smallest numbers in the list.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with a list of 5 numbers separated with comma: (ex: 5, 1, 9, 2, 10) ");
            List<int> intList = new List<int>();


            string input = Console.ReadLine();

            string[] inputArray = input.Split(", ");

            List<string> InputList = new List<string>(inputArray);

            foreach (string value in InputList)
            {
                if (int.TryParse(value, out int intValue))
                {
                    intList.Add(intValue);
                }
                else
                {
                    Console.WriteLine($"'{value}' is not a valid input.");
                }
            }

            if (intList.Count < 5)
            {
                Console.WriteLine("Invalid List");
            }
            else
            {
                List<int> smallestNumbers = intList.OrderBy(n => n).Take(3).ToList();
                Console.WriteLine("smallest numbers: ");
                foreach(int value in smallestNumbers)
                {
                    Console.WriteLine(value);
                }

            }

            







        }
    }
}
