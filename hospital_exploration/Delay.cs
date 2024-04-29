using System;
using System.Threading;

namespace hospital_escape
{
    public class Delay
    {
        public void PrintWithDelay(string text, int delayMilliseconds)
        {
            foreach (char c in text)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Enter)
                    {
                        while (Console.KeyAvailable)
                            Console.ReadKey(true);
                        Console.Write(text.Substring(text.IndexOf(c)));
                        return;
                    }
                }
                Console.Write(c);
                Thread.Sleep(delayMilliseconds);
            }
        }
    }
}
