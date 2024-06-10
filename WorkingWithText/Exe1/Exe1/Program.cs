namespace Exe1
{
    internal class Program
    {

        //Write a program and ask the user to enter a few numbers separated by a hyphen.
        //Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display
        //a message: "Consecutive"; otherwise, display "Not Consecutive".
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

            bool areConsecutive = true;
            for (int i = 1; i < intList.Count; i++)
            {
                if (intList[i] != intList[i - 1] + 1)
                {
                    areConsecutive = false;
                    break;
                }
            }

            bool areConsecutiveDescending = true;
            for (int i = 1; i < intList.Count; i++)
            {
                if (intList[i] != intList[i - 1] - 1)
                {
                    areConsecutiveDescending = false;
                    break;
                }
            }


            if (areConsecutive || areConsecutiveDescending)
            {
                Console.WriteLine("Consecutive");
            }
            else
                Console.WriteLine("Not Consecutive");
        }
    }
}
