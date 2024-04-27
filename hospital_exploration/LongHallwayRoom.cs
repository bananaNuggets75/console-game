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
                Console.WriteLine("After walking for what seems like hours, you saw an Alien and you woke up!");
                Console.WriteLine("Congratualations!! It was all a dream!");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter A or B.");
                game.ChangeRoom(this);
                break;
        }
    }
}
