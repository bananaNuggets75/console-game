using System;

namespace hospital_escape
{
    public abstract class Room
    {
        protected Game game;
        protected bool hasKey;
        protected Puzzle puzzle;

        public Room(Game game, bool hasKey)
        {
            this.game = game;
            this.hasKey = hasKey;
        }

        public abstract void Enter();

        public virtual void SearchRoom()
        {
            if (puzzle != null)
            {
                bool puzzleSolved = puzzle.Solve(game.Player);
                if (puzzleSolved && hasKey)
                {
                    Console.WriteLine("You find a key after solving the puzzle!");
                    hasKey = false;
                    game.Player.HasKey = true;
                }
                else
                {
                    Console.WriteLine("You didn't find anything useful.");
                }
            }
            else
            {
                if (hasKey)
                {
                    Console.WriteLine("You search the room and find a key hidden under the rug!");
                    hasKey = false;
                    game.Player.HasKey = true;
                }
                else
                {
                    Console.WriteLine("You search the room but find nothing of interest.");
                }
            }
        }
    }
}
