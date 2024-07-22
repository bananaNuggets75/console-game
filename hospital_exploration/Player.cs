using System;
using System.Collections.Generic;

namespace hospital_escape
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasKey { get; set; }
        public List<string> Inventory { get; set; }

        public Player()
        {
            Inventory = new List<string>();
        }

        public void AddItem(string item)
        {
            Inventory.Add(item);
            Console.WriteLine($"{item} has been added to your inventory.");
        }

        public void ShowInventory()
        {
            Console.WriteLine("Your inventory contains:");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
