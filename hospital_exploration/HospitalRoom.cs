using System;
using hospital_escape;

class HospitalRoom : Room
{
    public HospitalRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. Go back to sleep");
        Console.WriteLine("2. Explore");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Boring human. You could've explored the hospital and had fun.");
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
                break;
            case "2":
                game.ChangeRoom(new Hallway(game));
                break;
        }
    }
}
