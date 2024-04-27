using System;
using hospital_escape;


class Hallway : Room
{
    public Hallway(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("You decided to explore. After leaving your hospital room, you immediately find a hallway.");
        Console.WriteLine("What do you do?");
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
        }
    }
}
