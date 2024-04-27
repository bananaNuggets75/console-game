using System;
using hospital_escape;

namespace hospital_escape
{
    public abstract class Room
    {
        protected Game game;

        public Room(Game game)
        {
            this.game = game;
        }

        public abstract void Enter();
    }
}
