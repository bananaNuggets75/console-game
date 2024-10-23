using System;

namespace hospital_escape
{
    public class KitchenRoom : Room
    {
        private Delay delayPrint = new Delay();
        private Puzzle puzzle;

        public KitchenRoom(Game game) : base(game, hasKey: true)
        {
            this.puzzle = new FindRecipePuzzle(); 
        }

        public override void Enter()
        {
            delayPrint.PrintWithDelay("You enter the kitchen. The smell of something burnt lingers in the air. \n", 50);
            delayPrint.PrintWithDelay("There are various kitchen appliances and cabinets around. \n", 50);
            delayPrint.PrintWithDelay("What do you want to do? \n", 70);
            Console.WriteLine("1. Search the cabinets");
            Console.WriteLine("2. Try to cook something");
            Console.WriteLine("3. Leave the kitchen");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SearchCabinets(); // Trigger searching the cabinets for items or clues.
                    break;
                case "2":
                    Cook(); // Allow the player to try cooking.
                    break;
                case "3":
                    game.ChangeRoom(new Hallway(game)); // Go back to the hallway.
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    Enter(); // Retry entering the kitchen.
                    break;
            }
        }

        private void SearchCabinets()
        {
            if (hasKey)
            {
                bool solved = puzzle.Solve(game.Player);
                if (solved)
                {
                    hasKey = false; // Key is taken.
                    game.Player.AddItem("Recipe"); // Add a recipe to the player's inventory.
                    delayPrint.PrintWithDelay("You found a hidden recipe! It might be useful later.\n", 50);
                }
                else
                {
                    Console.WriteLine("You search the cabinets but find nothing of interest.");
                }
            }
            else
            {
                Console.WriteLine("You search the cabinets but find nothing of interest.");
            }
        }

        private void Cook()
        {
            delayPrint.PrintWithDelay("You attempt to cook something, but it's a disaster!\n", 50);
            delayPrint.PrintWithDelay("You accidentally set off the fire alarm. \n", 50);
            delayPrint.PrintWithDelay("GAME OVER\n", 80);
            Console.ReadLine();
        }
    }
}
