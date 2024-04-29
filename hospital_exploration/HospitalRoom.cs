using System;
using hospital_escape;

namespace hospital_escape
{
    public class HospitalRoom : Room
    {
        public HospitalRoom(Game game) : base(game, hasKey: true) { }
        private Delay delayPrint = new Delay();

        public override void Enter()
        {
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
                    game.ChangeRoom(new Hallway(game));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    game.ChangeRoom(this);
                    break;
            }
        }
    }
}
