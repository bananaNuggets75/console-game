//using System;
//using hospital_escape;

//public class CabinRoom : Room
//{
//    public CabinRoom(Game game) : base(game) { }
//    private Delay delayPrint = new Delay();

//    public override void Enter()
//    {
//        delayPrint.PrintWithDelay("You're about to enter the cabin, but before you walk in, you see a family full of people wearing rabbit masks. \n");
//        delayPrint.PrintWithDelay("What do you do? \n");
//        Console.WriteLine("A. Run");
//        Console.WriteLine("B. Approach them");

//        string choice = Console.ReadLine();

//        switch (choice.ToUpper())
//        {
//            case "A":
//                Console.WriteLine("They were not at all violent, but as everyone knows by now, the rabbit folk do not like impolite people.");
//                Console.WriteLine("They caught up to you and feasted on your remains.");
//                delayPrint.PrintWithDelay("GAME OVER");
//                Console.ReadLine();
//                break;
//            case "B":
//                Console.WriteLine("You sit down waiting for dinner, and they give you food. It smells odd.");
//                Console.WriteLine("What do you do?");
//                Console.WriteLine("A. Eat it");
//                Console.WriteLine("B. Run");

//                string foodChoice = Console.ReadLine();

//                switch (foodChoice.ToUpper())
//                {
//                    case "A":
//                        Console.WriteLine("You died after eating the food they gave you. It was human meat.");
//                        Console.WriteLine("The second door wasn't the best choice.");
//                        delayPrint.PrintWithDelay("GAME OVER");
//                        Console.ReadLine();
//                        break;
//                    case "B":
//                        Console.WriteLine("Too bad. Never trust anyone, but you will die either way stupid.");
//                        Console.WriteLine("The second door is absolute massacre. Curiosity kills dumb bitch.");
//                        delayPrint.PrintWithDelay("GAME OVER");
//                        Console.ReadLine();
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Please enter A or B.");
//                        game.ChangeRoom(this);
//                        break;
//                }
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please enter A or B.");
//                game.ChangeRoom(this);
//                break;
//        }
//    }
//}
