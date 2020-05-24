using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Sword
    {
        private int damage;

        public int Damage
        {
            get => this.damage;
            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentException("Damage must be greater than 0.");
                }
            }
        }

        public Sword() { }

        public void Bloodthirst() { }
    }
}
