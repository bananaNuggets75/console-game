using System;

namespace hospital_escape
{
    public class Hallway : Room
    {
        private Delay delayPrint = new Delay();
        private Puzzle puzzle;

        public Hallway(Game game) : base(game, hasKey: true)
        {
            puzzle = new FindKeyPuzzle(); // Assign a puzzle to the room
        }

        public override void Enter()
        {
            delayPrint.PrintWithDelay("You decided to explore. After leaving your hospital room, you immediately find a hallway. \n", 40);
            delayPrint.PrintWithDelay("What do you do? \n", 70);
            Console.WriteLine("1. Go back to sleep");
            Console.WriteLine("2. Explore");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    delayPrint.PrintWithDelay("Boring human. You could've explored the hospital and had fun. \n", 50);
                    delayPrint.PrintWithDelay("GAME OVER", 80);
                    Console.ReadLine();
                    break;
                case "2":
                    SearchRoom(); // Trigger search and puzzle solving
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    Enter(); // Stay in the same room for another attempt
                    break;
            }
        }

        public override void SearchRoom()
        {
            if (hasKey)
            {
                bool solved = puzzle.Solve(game.Player);
                if (solved)
                {
                    hasKey = false; // Key is taken
                    game.Player.HasKey = true;
                }
            }
            else
            {
                Console.WriteLine("You search the room but find nothing of interest.");
            }
            if (game.Player.HasKey)
            {
                game.ChangeRoom(new Hallway(game)); // Move to the next room if the key is found
            }
        }
    }
}
