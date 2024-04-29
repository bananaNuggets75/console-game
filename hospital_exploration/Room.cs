using System;

namespace hospital_escape
{
    public abstract class Room
    {
        protected Game game;
        protected bool hasKey;

        public Room(Game game, bool hasKey)
        {
            this.game = game;
            this.hasKey = hasKey;
        }

        public abstract void Enter();

        public virtual void SearchRoom()
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
