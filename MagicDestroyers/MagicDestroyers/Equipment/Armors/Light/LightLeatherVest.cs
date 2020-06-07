namespace Equipment.Armors.Light
{
    public class LightLeatherVest : Light
    {
        private const int DEFAULT_ARMOR_POINTS = 2;

        public LightLeatherVest()
            : this(DEFAULT_ARMOR_POINTS)
        { }

        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
