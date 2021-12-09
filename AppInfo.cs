using System;

namespace NumberGuesser
{
    public class AppInfo
    {
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
    }
}
