using System;
using hospital_escape;

class CheckSuppliesRoom : Room
{
    public CheckSuppliesRoom(Game game) : base(game, hasKey: true) { }
    private Delay delayPrint = new Delay();

    public override void Enter()
    {
        Console.WriteLine("You go to check out the supplies and realize it's just some bandaids and medicine.");
        delayPrint.PrintWithDelay("What do you do? \n", 70);
        Console.WriteLine("A. Eat the medicine");
        Console.WriteLine("B. Leave the room and keep walking without touching the medicine");

        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "A":
                Console.WriteLine("You eat the medicine and it was actually poison. Not a good idea to eat someone's medicine.");
                delayPrint.PrintWithDelay("GAME OVER", 80);
                Console.ReadLine();
                break;
            case "B":
                game.ChangeRoom(new Hallway(game));
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter A or B.");
                game.ChangeRoom(this);
                break;
        }
    }
}
