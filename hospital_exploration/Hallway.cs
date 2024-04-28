using System;
using hospital_escape;


class Hallway : Room
{
    public Hallway(Game game) : base(game) { }
    private Delay delayPrint = new Delay(50);

    public override void Enter()
    {
        delayPrint.PrintWithDelay("You decided to explore. After leaving your hospital room, you immediately find a hallway. \n");
        delayPrint.PrintWithDelay("What do you do? \n");
        Console.WriteLine("1. Enter a room");
        Console.WriteLine("2. Continue walking");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                game.ChangeRoom(new RandomRoom(game));
                break;
            case "2":
                game.ChangeRoom(new ContinueWalkingRoom(game));
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                game.ChangeRoom(this);
                break;
        }
    }
}
