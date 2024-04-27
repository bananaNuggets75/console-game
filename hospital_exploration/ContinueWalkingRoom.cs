using System;
using hospital_escape;

class ContinueWalkingRoom : Room
{
    public ContinueWalkingRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("You continue walking down the hallway.");
        Console.WriteLine("You find three doors. Which door will you go through? (1, 2, or 3)");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You go through the first door and find stairs.");
                game.ChangeRoom(new StairsRoom(game));
                break;
            case "2":
                Console.WriteLine("You go through the second door and find a forest with a small cabin in the middle.");
                game.ChangeRoom(new CabinRoom(game));
                break;
            case "3":
                Console.WriteLine("After walking into the third door, you realize there is nothing but a long hallway.");
                game.ChangeRoom(new LongHallwayRoom(game));
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                game.ChangeRoom(this);
                break;
        }
    }
}
