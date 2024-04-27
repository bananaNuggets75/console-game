using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Hospital Escape!");
        Console.WriteLine("You wake up in the hospital with absolutely no memory of who you are or what happened.");

        ExploreHospital();
    }

    static void ExploreHospital()
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
                ExploreHallway();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                ExploreHospital();
                break;
        }
    }

    static void ExploreHallway()
    {
        Console.WriteLine("You decided to explore. After leaving your hospital room, you immediately find a hallway.");
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. Enter a room");
        Console.WriteLine("2. Continue walking");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                ExploreRoom();
                break;
            case "2":
                ContinueWalking();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                ExploreHallway();
                break;
        }
    }

    static void ExploreRoom()
    {
        Console.WriteLine("You enter a random room. You see some supplies in the corner but nothing else too interesting.");
        Console.WriteLine("What do you do?");
        Console.WriteLine("1. Leave the room and keep walking");
        Console.WriteLine("2. Check out the supplies");

        string choice = Console.ReadLine();

        switch (choice.ToUpper())
        {
            case "1":
                ExploreHallway();
                break;
            case "2":
                CheckSupplies();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                ExploreRoom();
                break;
        }
    }

    static void CheckSupplies()
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
                ExploreHallway();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter A or B.");
                CheckSupplies();
                break;
        }
    }

    static void ContinueWalking()
    {
        Console.WriteLine("You continue walking down the hallway.");
        Console.WriteLine("You find three doors. Which door will you go through? (1, 2, or 3)");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("You go through the first door and find stairs.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("A. Go back to the hallway");
                Console.WriteLine("B. Go down the stairs");

                string stairChoice = Console.ReadLine();

                switch (stairChoice.ToUpper())
                {
                    case "A":
                        ExploreHallway();
                        break;
                    case "B":
                        Console.WriteLine("You go down multiple staircases, but they seem never-ending. You're stuck there forever.");
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter A or B.");
                        ContinueWalking();
                        break;
                }
                break;
            case "2":
                Console.WriteLine("You go through the second door and find a forest with a small cabin in the middle.");
                ExploreCabin();
                break;
            case "3":
                Console.WriteLine("After walking into the third door, you realize there is nothing but a long hallway.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("A. Go back to choosing from the three doors");
                Console.WriteLine("B. Continue walking down the hallway");

                string hallwayChoice = Console.ReadLine();

                switch (hallwayChoice.ToUpper())
                {
                    case "A":
                        ContinueWalking();
                        break;
                    case "B":
                        Console.WriteLine("After walking for what seems like hours, you finally find an exit. Congrats, you're free!");
                        Console.WriteLine("GAME OVER");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter A or B.");
                        ContinueWalking();
                        break;
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                ContinueWalking();
                break;
        }
    }

    static void ExploreCabin()
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
                        ContinueWalking();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter A or B.");
                        ExploreCabin();
                        break;
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter A or B.");
                ExploreCabin();
                break;
        }
    }
}
