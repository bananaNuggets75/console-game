using System;

namespace hospital_escape
{
    public class Game
    {
        private Room currentRoom;
        private Delay delayPrint = new Delay();
        public Player Player { get; set; }

        public Game()
        {
            Player = new Player();
        }

        public void Start()
        {
            bool playAgain;
            do
            {
                delayPrint.PrintWithDelay("Welcome to Hospital Escape!", 70);
                delayPrint.PrintWithDelay("You wake up in the hospital with absolutely no memory of who you are or what happened.", 50);

                currentRoom = new HospitalRoom(this);
                currentRoom.Enter();

                if (Player.HasKey)
                {
                    currentRoom = new HiddenKeyRoom(this);
                    currentRoom.Enter();
                }

                bool inputValidation;
                string playAgainChoice;
                do
                {
                    delayPrint.PrintWithDelay("Do you want to play again? (yes/exit)", 50);
                    playAgainChoice = Console.ReadLine()?.ToLower() ?? "";
                    inputValidation = playAgainChoice == "yes" || playAgainChoice == "exit";
                    if (!inputValidation)
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'exit'.");
                    }
                } while (!inputValidation);

                playAgain = playAgainChoice == "yes";
            } while (playAgain);

            delayPrint.PrintWithDelay("Thanks for playing!", 60);
        }

        public void ChangeRoom(Room newRoom)
        {
            currentRoom = newRoom;
            currentRoom.Enter();
        }
    }
}
