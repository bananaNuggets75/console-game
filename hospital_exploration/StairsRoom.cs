using System;
using hospital_escape;

class StairsRoom : Room
{
    public StairsRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("What do you do?");
        Console.WriteLine("A. Go back to the hallway");
        Console.WriteLine("B. Go down the stairs");

        string stairChoice = Console.ReadLine();

        switch (stairChoice.ToUpper())
        {
            case "A":
                game.ChangeRoom(new ContinueWalkingRoom(game));
                break;
            case "B":
                Console.WriteLine("You go down multiple staircases, but they seem never-ending. You're stuck there forever.");
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
                break;
        }
    }
}
