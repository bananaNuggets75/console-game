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
        private string saveFilePath = "save.json";

        public Game()
        {
            Player = new Player();
            currentRoom = new HospitalRoom(this);
        }

        public void Start()
        {
            LoadGame();
            Play();
        }

        public void Play()
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

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Go back to sleep");
                Console.WriteLine("2. Explore");
                Console.WriteLine("3. Save and exit");

                string playAgainChoice = Console.ReadLine();

                switch (playAgainChoice)
                {
                    case "1":
                        playAgain = true;
                        break;
                    case "2":
                        playAgain = false;
                        break;
                    case "3":
                        SaveGame();
                        playAgain = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter '1', '2', or '3'.");
                        playAgain = false;
                        break;
                }

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
