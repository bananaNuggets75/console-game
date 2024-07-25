using System;
using System.Collections.Generic;

namespace hospital_escape
{
    public class Player
    {
        public bool HasKey { get; set; }
        private List<string> inventory;

        public Player()
        {
            inventory = new List<string>();
        }

        public void AddItem(string item)
        {
            inventory.Add(item);
            if (item == "Key")
            {
                HasKey = true;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
