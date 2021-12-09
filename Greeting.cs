using System;

namespace NumberGuesser
{
    public class Greeting
    {
        static void Greet()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}! let's play a game!", userName);
        }
    }
}
