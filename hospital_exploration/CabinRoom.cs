using System;
using hospital_escape;

class CabinRoom : Room
{
    public CabinRoom(Game game) : base(game) { }

    public override void Enter()
    {
        Console.WriteLine("You're about to enter the cabin, but before you walk in, you see a family full of people wearing rabbit masks.");
        Console.WriteLine("What do you do?");
        Console.WriteLine("A. Run");
        Console.WriteLine("B. Approach them");

        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "A":
                Console.WriteLine("They were not at all violent, but as everyone knows by now, the rabbit folk do not like impolite people.");
                Console.WriteLine("They caught up to you and feasted on your remains.");
                Console.WriteLine("GAME OVER");
                break;
            case "B":
                Console.WriteLine("You sit down waiting for dinner, and they give you food. It smells odd.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("A. Eat it");
                Console.WriteLine("B. Run");

                string foodChoice = Console.ReadLine();

                switch (foodChoice.ToUpper())
                {
                    case "A":
                        Console.WriteLine("You died after eating the food they gave you. It was human meat.");
                        Console.WriteLine("The second door wasn't the best choice.");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        break;
                    case "B":
                        game.ChangeRoom(new ContinueWalkingRoom(game));
                        break;
                }
                break;
        }
    }
}
