using System;

namespace hospital_escape
{
    public interface Puzzle
    {
        bool Solve(Player player);
    }

    public class FindKeyPuzzle : Puzzle
    {
        public bool Solve(Player player)
        {
            Console.WriteLine("You find a puzzle in the room. Solve it to find the key.");
            Console.WriteLine("Here's a simple question: What is 2 + 2?");
            string answer = Console.ReadLine();
            if (answer == "4")
            {
                Console.WriteLine("Correct! You found the key.");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect. Try again later.");
                return false;
            }
        }
    }
}
