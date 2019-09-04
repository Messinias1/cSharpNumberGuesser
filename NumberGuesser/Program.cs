using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Carl Kakisis";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write Out App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();

            // Ask User's Name
            Console.WriteLine("What is your name?");

            // Get User input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0} want to play a game?", input);
        }
    }
}
