//using System;
//using hospital_escape;

//class StairsRoom : Room
//{
//    public StairsRoom(Game game) : base(game) { }
//    private Delay delayPrint = new Delay(70);

//    public override void Enter()
//    {
//        delayPrint.PrintWithDelay("What do you do? \n");
//        Console.WriteLine("A. Go back to the hallway");
//        Console.WriteLine("B. Go down the stairs");

//        string stairChoice = Console.ReadLine();

//        switch (stairChoice.ToUpper())
//        {
//            case "A":
//                game.ChangeRoom(new ContinueWalkingRoom(game));
//                break;
//            case "B":
//                Console.WriteLine("You go down multiple staircases, but they seem never-ending. You're stuck there forever.");
//                delayPrint.PrintWithDelay("GAME OVER");
//                Console.ReadLine();
//                break;
//            default:
//                Console.WriteLine("Invalid choice. Please enter A or B.");
//                game.ChangeRoom(this);
//                break;
//        }
//    }
//}
