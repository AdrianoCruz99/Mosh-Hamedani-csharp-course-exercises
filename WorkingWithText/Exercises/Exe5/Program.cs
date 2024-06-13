namespace Exe5
{
    internal class Program
    {
        //Write a program and ask the user to enter an English word.
        //Count the number of vowels (a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.
        static void Main(string[] args)
        {
            Console.WriteLine("Vowels count. Type a word: ");

            string input = Console.ReadLine();

            char[] letters = input.ToCharArray();
            int count = 0;
            foreach(char letter in letters)
            {
                if (letter == 'a')
                {
                    count++;
                }
                else if(letter == 'e')
                {
                    count++;
                }
                else if (letter == 'i')
                {
                    count++;
                }
                else if (letter == 'o')
                {
                    count++;
                }
                else if (letter == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
