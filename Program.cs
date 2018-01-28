using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            AppInfo();
            int incorrectGuesses = 0;
            Random random = new Random();
            while (true)
            {
                int guess = 0;
                int correctGuess = random.Next(1, 10);
                while (guess != correctGuess)
                {

                    correctGuess = random.Next(1, 10);
                    Console.Write("Enter a number between 1 and 10:");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        changeColor(ConsoleColor.Red, "Please enter a number, doofus!");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctGuess)
                    {
                        incorrectGuesses++;
                        changeColor(ConsoleColor.Red, "Incorrect guess!  Number of incorrect guesses: " + incorrectGuesses);
                    }
                }//end first while loop
                changeColor(ConsoleColor.Yellow, "You are correct! Would you like to play again? (y/n)");
                string playagain = Console.ReadLine().ToUpper();
                if (playagain == "Y")
                {
                    incorrectGuesses = 0;
                    continue;
                }
                else if (playagain == "N")
                {
                    changeColor(ConsoleColor.Blue, "Thanks for playing!  Press any key to close the window...");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    changeColor(ConsoleColor.Blue, "Thanks for playing!  Press any key to close the window...");
                    Console.ReadKey();
                    return;
                }
            }//end second while loop
        }// end Main function

        static void changeColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void AppInfo()
        {
            string appAuthor = "Marco Principio";
            string appVersion = "1.0.0";
            string appName = "Number Guesser";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}