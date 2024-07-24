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
        }

        public void Start()
        {
            LoadGame(); // Attempt to load a previous save

            delayPrint.PrintWithDelay("Welcome to Hospital Escape! \n", 70);
            delayPrint.PrintWithDelay("You wake up in the hospital with absolutely no memory of who you are or what happened. \n", 50);

            currentRoom = new HospitalRoom(this);
            currentRoom.Enter();

            if (Player.HasKey)
            {
                currentRoom = new HiddenKeyRoom(this);
                currentRoom.Enter();
            }
        }

        public void ChangeRoom(Room newRoom)
        {
            currentRoom = newRoom;
            currentRoom.Enter();
        }

        public void ExploreRoom()
        {
            hiddenScenario.TriggerHiddenScenario(Player);
            SolvePuzzle(new FindKeyPuzzle());
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

        private bool ShouldSaveGame()
        {
            Console.WriteLine("Press 'S' to save the game or any other key to continue.");
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
            return keyInfo.Key == ConsoleKey.S;
        }

        // Main game loop
        public void Play()
        {
            while (true)
            {
                Console.WriteLine("\nWhat do you want to do?");
                Console.WriteLine("1. Go back to sleep");
                Console.WriteLine("2. Explore");
                Console.WriteLine("3. Save and exit");
                Console.WriteLine("4. Show Inventory");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        delayPrint.PrintWithDelay("You decide to go back to sleep. Maybe this is all just a dream...\n", 50);
                        return; // End the game loop

                    case "2":
                        ExploreRoom();
                        break;

                    case "3":
                        if (ShouldSaveGame())
                        {
                            SaveGame();
                            return; // Exit the game loop after saving
                        }
                        break;

                    case "4":
                        Player.ShowInventory();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }

            // Additional cleanup or closing logic if needed
            Console.WriteLine("Exiting the game...");
        }

        private void SolvePuzzle(Puzzle puzzle)
        {
            bool puzzleSolved = puzzle.Solve(Player);
            if (puzzleSolved)
            {
                Console.WriteLine("You have solved the puzzle!");
            }
            else
            {
                Console.WriteLine("You failed to solve the puzzle.");
            }
        }
    }
}
