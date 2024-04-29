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
                Console.Write(c);
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                Thread.Sleep(delayMilliseconds);
            }
        }
    }
}
