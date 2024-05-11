using System;
using System.IO;
using Newtonsoft.Json;

namespace hospital_escape
{
    public class Game
    {
        private Room currentRoom;
        private Delay delayPrint = new Delay();
        private HiddenScenario hiddenScenario = new HiddenScenario();
        public Player Player { get; set; }
        private Player player;
        private string saveFilePath = "save.json";

        public Game()
        {
            Player = new Player();
        }

        public void Start()
        {
            bool playAgain;
            do
            {
                delayPrint.PrintWithDelay("Welcome to Hospital Escape! \n", 70);
                delayPrint.PrintWithDelay("You wake up in the hospital with absolutely no memory of who you are or what happened. \n", 50);

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
                    delayPrint.PrintWithDelay("Do you want to play again? (yes/exit) \n", 50);
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

        public void ExploreRoom()
        {
            hiddenScenario.TriggerHiddenScenario(Player);
        }

        public void SaveGame()
        {
            try
            {
                string gameStateJson = JsonConvert.SerializeObject(Player);
                File.WriteAllText(saveFilePath, gameStateJson);
                Console.WriteLine("Game saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving game: {ex.Message}");
            }
        }

        public void LoadGame()
        {
            try
            {
                if (File.Exists(saveFilePath))
                {
                    string gameStateJson = File.ReadAllText(saveFilePath);
                    Player = JsonConvert.DeserializeObject<Player>(gameStateJson);
                    Console.WriteLine("Game loaded successfully.");
                }
                else
                {
                    Console.WriteLine("No saved game found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading game: {ex.Message}");
            }
        }
    }
}
