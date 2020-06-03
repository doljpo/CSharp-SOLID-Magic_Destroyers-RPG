namespace Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE = 10;
        public Staff()
            : this(DEFAULT_DAMAGE)
        { }

        public Staff(int damage)
        {
            this.Damage = damage;
        }

        public void Empower() { }
    }
}
