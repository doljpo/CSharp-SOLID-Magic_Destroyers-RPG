namespace Equipment.Armors.Cloth
{
    public class ClothRobe : Cloth
    {
        private const int DEFAULT_ARMOR_POINTS = 1;

        public ClothRobe()
            : this(DEFAULT_ARMOR_POINTS)
        { }

        public ClothRobe(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}
