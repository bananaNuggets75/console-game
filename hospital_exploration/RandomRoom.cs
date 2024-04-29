using System;
using hospital_escape;

class RandomRoom : Room
{
    public RandomRoom(Game game) : base(game, hasKey: true) { }
    private Delay delayPrint = new Delay();
    public override void Enter()
    {
        delayPrint.PrintWithDelay("You enter a random room. You see some supplies in the corner but nothing else too interesting. \n", 40);
        delayPrint.PrintWithDelay("What do you do? \n", 70);
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
            default:
                Console.WriteLine("Invalid choice. Please enter A or B.");
                game.ChangeRoom(this);
                break;
        }
    }
}
