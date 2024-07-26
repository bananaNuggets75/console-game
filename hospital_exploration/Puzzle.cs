using System;

namespace hospital_escape
{
    public abstract class Puzzle
    {
        public abstract bool Solve(Player player);
    }

    public class FindKeyPuzzle : Puzzle
    {
        private Delay delayPrint = new Delay();

        public override bool Solve(Player player)
        {
            delayPrint.PrintWithDelay("You need to solve a puzzle to find the key. Answer the question correctly.\n", 70);
            Console.WriteLine("What has keys but can't open locks?");
            string answer = Console.ReadLine()?.ToLower();

            if (answer == "piano")
            {
                delayPrint.PrintWithDelay("Correct! You found the key!\n", 70);
                return true;
            }
            else
            {
                delayPrint.PrintWithDelay("Incorrect! Try searching the room again.\n", 70);
                return false;
            }
        }
    }
}
