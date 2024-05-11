using System;
using Newtonsoft.Json;

namespace hospital_escape
{

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();
            game.Player.UseKey();
        }
    }
}
