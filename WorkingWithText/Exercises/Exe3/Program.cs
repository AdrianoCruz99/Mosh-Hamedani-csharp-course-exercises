namespace Exe3
{
    internal class Program
    {
        //Write a program and ask the user to enter a time value in
        //the 24-hour time format (e.g. 19:00).
        //A valid time should be between 00:00 and 23:59.
        //If the time is valid, display "Ok"; otherwise,
        //display "Invalid Time".
        //If the user doesn't provide
        //any values, consider it as invalid time.
        static void Main(string[] args)
        {
            Console.WriteLine("insert a time value (ex: 19:00): ");

            string userInput = Console.ReadLine();

            string format = "HH:mm";

            if (DateTime.TryParseExact(userInput, format, null, System.Globalization.DateTimeStyles.None, out DateTime currentHour))
            {
                Console.WriteLine($"Ok {currentHour.TimeOfDay}");
            }
            else if(string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Invalid Time");
            }
            else 
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
