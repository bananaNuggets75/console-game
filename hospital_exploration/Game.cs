using System;
using hospital_escape;

class Game
{
    private Room currentRoom;

    public void Start()
    {
        Console.WriteLine("Welcome to the Hospital Escape!");
        Console.WriteLine("You wake up in the hospital with absolutely no memory of who you are or what happened.");

        currentRoom = new HospitalRoom(this);
        currentRoom.Enter();
    }

    public void ChangeRoom(Room newRoom)
    {
        currentRoom = newRoom;
        currentRoom.Enter();
    }
}
