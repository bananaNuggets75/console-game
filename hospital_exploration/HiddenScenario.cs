using System;

namespace hospital_escape
{
    public class HiddenScenario
    {
        private Random random = new Random();
        private Delay delayPrint = new Delay();

        public void TriggerHiddenScenario(Player player)
        {
            int chance = random.Next(1, 10);

            if (player.HasKey && chance <= 98)
            {
                delayPrint.PrintWithDelay("You stumble upon a hidden room!", 50);
            }
        }
    }
}
