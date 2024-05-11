using System;

namespace hospital_escape
{
    public class PlayerSaveInfo
    {
        public string Name { get; }
        public int Age { get; }

        public PlayerSaveInfo(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static PlayerSaveInfo InputUserInfo()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int age = PromptForAge();

            return new PlayerSaveInfo(name, age);
        }

        static int PromptForAge()
        {
            int age;
            bool validInput = false;

            do
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                validInput = int.TryParse(input, out age);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                }
            } while (!validInput);

            return age;
        }
    }
}
