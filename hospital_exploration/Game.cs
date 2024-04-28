using System;
using hospital_escape;

namespace hospital_escape
{

    public class Game
    {
        private Room currentRoom;
        private Delay delayPrint = new Delay(30);

        public void Start()
        {
            bool playAgain;
            do
            {
                delayPrint.PrintWithDelay("Welcome to Hospital Escape! \n");
                delayPrint.PrintWithDelay("You wake up in the hospital with absolutely no memory of who you are or what happened. \n");

                currentRoom = new HospitalRoom(this);
                currentRoom.Enter();

                bool InputValidation;
                string playAgainChoice;

                do
                {
                    delayPrint.PrintWithDelay("Do you want to play again? (yes/exit)");
                    playAgainChoice = Console.ReadLine()?.ToLower() ?? "";
                    InputValidation = playAgainChoice == "yes" || playAgainChoice == "exit";
                    if (!InputValidation)
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'exit'.");
                    }
                } while (!InputValidation);

                playAgain = playAgainChoice == "yes";
            } while (playAgain);

            delayPrint.PrintWithDelay("Thanks dumbass!");
        }

        public void ChangeRoom(Room newRoom)
        {
            currentRoom = newRoom;
            currentRoom.Enter();
        }
    }
}
