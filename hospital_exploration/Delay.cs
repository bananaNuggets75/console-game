using System;
using System.Threading;

namespace hospital_escape
{
    public class Delay
    {
        private int delayMilliseconds;

        public Delay(int delayMilliseconds)
        {
            this.delayMilliseconds = delayMilliseconds;
        }

        public void PrintWithDelay(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMilliseconds);
            }
        }
    }
}
