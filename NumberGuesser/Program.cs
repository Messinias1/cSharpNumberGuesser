using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run this function

            GreetUser();  

            // keep playing
            while(true)
            {
                // create a new random object
                Random random = new Random();
                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask userfor number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    // Make sure input is number
                    if (!int.TryParse(input, out guess))
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");


                        // keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct Number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again!!");
                    }
                }
                // number is correct
                PrintColorMessage(ConsoleColor.Green, "YOU GUESSED CORRECT!!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // get and display app info
        static void GetAppInfo()
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
        }

        // ask users name and greet
        static void GreetUser()
        {
            // Ask User's Name
            Console.WriteLine("What is your name?");

            // Get User input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0} want to play a game?", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // tell user not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
