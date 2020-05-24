using System;

namespace MagicDestroyers.Equipment.Armors
{
    public class Chainlink
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get => this.armorPoints;
            set
            {
                if (value > 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentException("Armor Points must be greater than 0.");
                }
            }
        }

        public Chainlink() { }
    }
}
