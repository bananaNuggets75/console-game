using System;

namespace hospital_escape
{
    public class HiddenScenario
    {
        private Random random = new Random();
        private Delay delayPrint = new Delay();

        public void TriggerHiddenScenario(Player player)
        {
            int chance = random.Next(1, 3);

            if (player.HasKey && chance <= 100)
            {
                delayPrint.PrintWithDelay("You stumble upon a hidden room!", 50);
            }
        }


    }
}
