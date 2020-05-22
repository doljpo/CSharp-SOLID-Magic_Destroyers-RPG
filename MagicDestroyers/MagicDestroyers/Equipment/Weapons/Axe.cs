using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Axe
    {
        private int damage;

        public int Damage
        {
            get => damage;
            set
            {
                if (value > 0)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentException("Damage must be greater than 0.");
                }
            }
        }

        public Axe() { }

        public void HackNSlash() { }
    }
}
