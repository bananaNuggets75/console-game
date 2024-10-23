using System;

namespace hospital_escape
{
    public class HospitalRoom : Room
    {
        private Delay delayPrint = new Delay();
        private Puzzle puzzle;

        public HospitalRoom(Game game) : base(game, hasKey: true)
        {
            this.puzzle = new FindKeyPuzzle(); // Assign a puzzle to the room
        }

        public override void Enter()
        {
            delayPrint.PrintWithDelay("You wake up in a hospital room. The faint sound of machines beeping fills the air.\n", 50);
            delayPrint.PrintWithDelay("What do you want to do? \n", 70);
            Console.WriteLine("1. Go back to sleep");
            Console.WriteLine("2. Explore the room");

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
                    game.Player.HasKey = true; // Player obtains the key
                    delayPrint.PrintWithDelay("You found the key hidden under the bed!\n", 50);
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
