namespace Exe2
{
    internal class Program
    {
        //Write a program and ask the user to enter a few numbers separated by a
        //hyphen. If the user simply presses Enter, without supplying an input, exit immediately;
        //otherwise, check to see if there are duplicates. If so, display "Duplicate" on
        //the console.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with numbers separeted by hyphen: ");

            List<int> intList = new List<int>();

            string input = Console.ReadLine();

            string[] inputArray = input.Split("-");

            List<string> inputList = new List<string>(inputArray);

            foreach (string value in inputList)
            {
                if (int.TryParse(value, out int intValue))
                {
                    intList.Add(intValue);
                }
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No inputs, closing the program.");
                    Environment.Exit(0);
            }


            Duplicated(intList);
            

        }
        public static bool Duplicated(List<int> intList)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (int value in intList) 
            {
                if (!result.Add(value))
                {
                    Console.WriteLine("Duplicated.");
                    return true;

                }
            }
            return false;
        }
    }
}
