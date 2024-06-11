using System.Globalization;

namespace Ex4
{
    internal class Program
    {
        /*Write a program and ask the user to enter a few words 
         * separated by a space. Use the words to create a variable name 
         * with PascalCase. For example, if the user types: "number of students", 
         * display "NumberOfStudents". Make sure that the program is not dependent 
         * on the input. So, if the user types "NUMBER OF STUDENTS", 
         * the program should still display "NumberOfStudents".*/
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal case converter: ");
            string userInput = Console.ReadLine();

            string pascalCaseString = ConvertToPascalCase(userInput);
            Console.WriteLine($"PascalCase: {pascalCaseString}");

        }

        static string ConvertToPascalCase(string input)
        {
            input = input.ToLower();

            string[] words = input.Split(' ');

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = textInfo.ToTitleCase(words[i]);
            }

            string result = string.Join("", words);
            return result;
        }
    }
}
