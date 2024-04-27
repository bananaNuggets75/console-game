using System;
using hospital_escape;

class LongHallwayRoom : Room
{
    public LongHallwayRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("What do you do?");
        Console.WriteLine("A. Go back to choosing from the three doors");
        Console.WriteLine("B. Continue walking down the hallway");

        string hallwayChoice = Console.ReadLine();

        switch (hallwayChoice.ToUpper())
        {
            case "A":
                game.ChangeRoom(new ContinueWalkingRoom(game));
                break;
            case "B":
                Console.WriteLine("After walking for what seems like hours, you finally find an exit. Congrats, you're free!");
                Console.WriteLine("Congratualations!!");
                Console.ReadLine();
                break;
        }
    }
}
