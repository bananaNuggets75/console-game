﻿using System;
using hospital_escape;

class CheckSuppliesRoom : Room
{
    public CheckSuppliesRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("You go to check out the supplies and realize it's just some bandaids and medicine.");
        Console.WriteLine("What do you do?");
        Console.WriteLine("A. Eat the medicine");
        Console.WriteLine("B. Leave the room and keep walking without touching the medicine");

        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "A":
                Console.WriteLine("You eat the medicine and it was actually poison. Not a good idea to eat someone's medicine.");
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
                break;
            case "B":
                game.ChangeRoom(new Hallway(game));
                break;
        }
    }
}
