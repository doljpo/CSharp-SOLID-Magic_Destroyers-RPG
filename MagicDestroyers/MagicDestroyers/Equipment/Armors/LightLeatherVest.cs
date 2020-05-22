using System;

namespace MagicDestroyers.Equipment.Armors
{
    public class LightLeatherVest
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get => armorPoints;
            set
            {
                if (value > 0)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentException("Armor Points must be greater than 0.");
                }
            }
        }

        public LightLeatherVest() { }
    }
}
