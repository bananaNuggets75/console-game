using System;

namespace hospital_escape
{
    public class Player
    {
        public bool HasKey { get; set; }

        public Player()
        {
            HasKey = false;
        }
        public void UseKey()
        {
            if (HasKey)
            {
                
                Console.WriteLine("You use the key to unlock the door.");
            }
            else
            {
                
                Console.WriteLine("You don't have a key to use.");
            }
        }
    }
}

