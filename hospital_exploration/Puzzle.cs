namespace hospital_escape
{
    public abstract class Puzzle
    {
        public abstract bool Solve(Player player);
    }

    public class FindKeyPuzzle : Puzzle
    {
        public override bool Solve(Player player)
        {
            Console.WriteLine("You see a key hidden in the corner of the room. Do you pick it up? (yes/no)");
            string input = Console.ReadLine()?.ToLower() ?? "";
            if (input == "yes")
            {
                player.AddItem("Key");
                Console.WriteLine("You picked up the key!");
                return true;
            }
            else
            {
                Console.WriteLine("You decided not to pick up the key.");
                return false;
            }
        }
    }
}
