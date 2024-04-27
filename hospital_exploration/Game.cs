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

                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgainChoice = Console.ReadLine()?.ToLower() ?? "";
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
