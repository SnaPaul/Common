using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 0 and 10.");

                while (guess != correctNumber)
                {
                    string inputNumber = Console.ReadLine();

                    if (!int.TryParse(inputNumber, out guess))
                    {               
                        PrintedColoredConsoleMessage(ConsoleColor.Yellow, "This is not a number!!!");
                        continue;
                    }


                    guess = Int32.Parse(inputNumber);

                    if (guess != correctNumber)
                    {
                        PrintedColoredConsoleMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    }
                }

                PrintedColoredConsoleMessage(ConsoleColor.Blue, "Right Number");

                Console.WriteLine("");

                PrintedColoredConsoleMessage(ConsoleColor.Cyan, "Like to play again?");
                PrintedColoredConsoleMessage(ConsoleColor.Cyan, "Type Yes otherwise the game ends!!!");

                string answer = Console.ReadLine().ToUpper();
                Console.ResetColor();

                if (answer != "YES")
                {
                    break;
                }
            }
        }

        static void AppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAutor = "Me Myself";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}.", appName, appVersion, appAutor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintedColoredConsoleMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
