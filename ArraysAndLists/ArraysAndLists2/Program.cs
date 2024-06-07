using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArraysAndLists2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program and ask the user to enter their name.Use an array to reverse the
            //name and then store the result in a new string.Display the reversed name on the console.

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);

            string reversedName = new string(nameArray);

            Console.WriteLine(reversedName);
        }
    }
}
