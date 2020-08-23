using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run appInfo

            GreetUser(); // Ask for users name and greet

            while (true) { 

            // int correctNumber = 7;

            // Create a new Random object
            Random random = new Random();

            // Set correct number
            int correctNumber = random.Next(1, 10);

            // Init gues var
            int guess = 0;

            // Asc user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while (guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // make sure its a number
                if (!int.TryParse(input, out guess))
                {
                     // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use az actual number");

                    // Keep going
                        continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    // print error message
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                }
            }
                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!!! You guessed it!");

                // Ask to play again

                Console.WriteLine("Play Again? [Y or N]?");

                // Get answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Svetlozar Antonov";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Whrite out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Text color reset to white
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
            
    }
}
