using System;

namespace hospital_escape
{
    public class HiddenKeyRoom : Room
    {
        private Delay printDelay = new Delay();
        public HiddenKeyRoom(Game game) : base(game, true) { }

        public override void Enter()
        {
            printDelay.PrintWithDelay("You enter a dimly lit room with a table, a chair, and a rug on the floor.", 50);
            printDelay.PrintWithDelay("What do you do? \n", 70);
            Console.WriteLine("A. Search the room");
            Console.WriteLine("B. Leave the room");

            string choice = Console.ReadLine()?.ToUpper() ?? "";
            switch (choice)
            {
                case "A":
                    SearchRoom();
                    break;
                case "B":
                    Console.WriteLine("You decide to leave the room.");
                    game.ChangeRoom(new Hallway(game)); // undecided which room. also needs to add logic
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
