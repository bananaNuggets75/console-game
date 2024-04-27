using System;
using hospital_escape;

class RandomRoom : Room
{
    public RandomRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("You enter a random room. You see some supplies in the corner but nothing else too interesting.");
        Console.WriteLine("What do you do?");
        Console.WriteLine("A. Leave the room and keep walking");
        Console.WriteLine("B. Check out the supplies");

        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "A":
                game.ChangeRoom(new Hallway(game));
                break;
            case "B":
                game.ChangeRoom(new CheckSuppliesRoom(game));
                break;
        }
    }
}
