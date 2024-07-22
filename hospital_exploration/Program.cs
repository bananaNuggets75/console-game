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
            game.Play();
            PlayerSaveInfo userInfo = PlayerSaveInfo.InputUserInfo();
            Console.WriteLine($"Name: {userInfo.Name}, Age: {userInfo.Age}");
        }
    }
}
