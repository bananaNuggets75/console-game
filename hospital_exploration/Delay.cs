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
                Thread.Sleep(delayMilliseconds);
            }
        }
    }
}
