using static System.Console;
using System;
using System.Threading;

namespace Psychosis
{
    class TextAnimation
    {
        public enum Direction
        {
            Left = '⇦',
            Down = '⇩',
            Up = '⇧',
            Right = '⇨'
        }

        public enum Selection
        {
            Current = '⋙',
            Confirm = '✔',
            Deny = '✖'
        }

        public static void GameTitle()
        {
            WriteLine(@"
  _____                         _                     _       
 |  __ \                       | |                   (_)      
 | |__) |  ___   _   _    ___  | |__     ___    ___   _   ___ 
 |  ___/  / __| | | | |  / __| | '_ \   / _ \  / __| | | / __|
 | |      \__ \ | |_| | | (__  | | | | | (_) | \__ \ | | \__ \
 |_|      |___/  \__, |  \___| |_| |_|  \___/  |___/ |_| |___/
                  __/ |                                       
                 |___/                                         ");
        }

        public static void PlayDeadAnimation()
        {
            Clear();
            SetConsoleColor(ConsoleColor.Yellow, ConsoleColor.Black);

            var frames = new[] { "( 0 0 )", "( O O )", "( o o )", "( O O )", "( O o )", "( O - )" };
            foreach (var frame in frames)
            {
                WriteLine(frame);
                Thread.Sleep(314);
                Clear();
            }

            Thread.Sleep(500); // Extra pause on the final frame
            ResetConsoleColor();
        }

        public static void Say(string message, ConsoleColor color, int speed)
        {
            PreserveConsoleColor(() =>
            {
                ForegroundColor = color;
                foreach (var c in message)
                {
                    Write(c);
                    Thread.Sleep(speed);
                    if (".?!,".Contains(c)) Thread.Sleep(c == ',' ? 250 : 500);
                    else if (c == ' ') Thread.Sleep(50);
                }
                WriteLine();
            });
        }

        public static void WaitForKey(string message = "Press any key to continue...")
        {
            WriteLine(message);
            ReadKey(true);
            Clear();
        }

        public static void PrintList<T>(T[] array)
        {
            WriteLine(string.Join(" ", array));
        }

        public static void CopyList<T>(T[] source, T[] destination)
        {
            Array.Copy(source, destination, source.Length);
        }

        private static void SetConsoleColor(ConsoleColor foreground, ConsoleColor background)
        {
            ForegroundColor = foreground;
            BackgroundColor = background;
        }

        private static void ResetConsoleColor()
        {
            ResetColor();
        }

        private static void PreserveConsoleColor(Action action)
        {
            var originalColor = ForegroundColor;
            action();
            ForegroundColor = originalColor;
        }

        /// <summary>
        /// Function to display a message with specified color.
        /// </summary>
        /// <param name="message">The message to display.</param>
        /// <param name="color">The color of the message.</param>
        public static void DisplayMessage(string message, ConsoleColor color)
        {
            ForegroundColor = color;
            WriteLine(message);
            ResetColor();
        }
    }
}