using System;
using hospital_escape;

namespace hospital_escape
{

    public class Game
    {
        private Room currentRoom;

        public void Start()
        {
            bool playAgain;
            do
            {
                Console.WriteLine("Welcome to Hospital Escape!");
                Console.WriteLine("You wake up in the hospital with absolutely no memory of who you are or what happened.");

                currentRoom = new HospitalRoom(this);
                currentRoom.Enter();

                bool InputValidation;
                string playAgainChoice;

                do
                {
                    Console.WriteLine("Do you want to play again? (yes/exit)");
                    playAgainChoice = Console.ReadLine()?.ToLower() ?? "";
                    InputValidation = playAgainChoice == "yes" || playAgainChoice == "exit";
                    if (!InputValidation)
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'exit'.");
                    }
                } while (!InputValidation);

                playAgain = playAgainChoice == "yes";
            } while (playAgain);

        Console.WriteLine("Thanks dumbass!");
        }

        public void ChangeRoom(Room newRoom)
        {
            currentRoom = newRoom;
            currentRoom.Enter();
        }
    }
}
