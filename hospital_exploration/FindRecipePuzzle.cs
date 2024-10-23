using System;

namespace hospital_escape
{
    public class FindRecipePuzzle : Puzzle
    {
        public bool Solve(Player player)
        {
            Console.WriteLine("You find a recipe in the cabinet. Solve this puzzle to cook something delicious!");
            Console.WriteLine("What is the secret ingredient in a famous chocolate cake?");
            Console.WriteLine("1. Flour");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Eggs");
            string answer = Console.ReadLine();

            if (answer == "2")
            {
                Console.WriteLine("Correct! You now have the recipe to cook a delicious cake.");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect. You need to find the right ingredient to continue.");
                return false;
            }
        }
    }
}
