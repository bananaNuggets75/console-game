using System;
using hospital_escape;

class LongHallwayRoom : Room
{
    public LongHallwayRoom(Game game) : base(game) { }
    private Delay delayPrint = new Delay(70);

    public override void Enter()
    {
        delayPrint.PrintWithDelay("What do you do? \n");
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
                delayPrint.PrintWithDelay("Congratualations!! It was all a dream!");
                Console.ReadLine();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter A or B.");
                game.ChangeRoom(this);
                break;
        }
    }
}
