using System;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // APPLICATION INFORMATION
            GetAppInfo();

            // GREET USER
            GreetUser();

            // RUN APPLICATION
            RunApp();
        }

        static void GetAppInfo()
        {
            string appName = "NUMBER GUESSER";
            string appVersion = "1.0.0";
            string appAuthor = "Eric Sanders";

            // APP INFO
            Console.WriteLine("---------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} | Version {1} | By {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
            Console.WriteLine("---------------------------------------------------------");
        }

        static void GreetUser()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            if(int.TryParse(userName, out int compName))
            {
                int value = compName;
                string binary = Convert.ToString(value, 2);
                Console.WriteLine("Hello, {0}! let's play a game!", binary);
            }
            else
            {
                Console.WriteLine("Hello, {0}! let's play a game!", userName);
            }
        }

        static void RunApp()
        {
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int userGuess = 0;

                Console.Write("Guess a number between 1 and 10: ");

                while (userGuess != correctNumber)
                {
                    string guess = Console.ReadLine();

                    if (!int.TryParse(guess, out userGuess))
                    {
                        PrintMessage("NotANumber");
                        continue;
                    }

                    userGuess = Int32.Parse(guess);

                    if (userGuess != correctNumber)
                    {
                        PrintMessage("WrongNumber");
                    }
                }

                PrintMessage("CorrectNumber");

                Farewell();
            }
        }

        static void Farewell()
        {
            while (true)
            {
                Console.WriteLine("Would you like to play again? [Y / N]: ");
                string userRes = Console.ReadLine().ToUpper();
                if (userRes == "Y" || userRes == "YES")
                {
                    RunApp();
                }
                else if (userRes == "N" || userRes == "NO")
                {
                    Console.WriteLine("Goodbye, thank you for playing!");
                    System.Environment.Exit(0);
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
        }

        static void PrintMessage(string messageType)
        {
            if(messageType == "NotANumber")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("That is not a number, please enter a real number.  ");
                Console.ResetColor();
            }

            if (messageType == "CorrectNumber")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("CORRECT!");
                Console.ResetColor();
            }

            if (messageType == "WrongNumber")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Guess again! ");
                Console.ResetColor();
            }
        }
    }
}
