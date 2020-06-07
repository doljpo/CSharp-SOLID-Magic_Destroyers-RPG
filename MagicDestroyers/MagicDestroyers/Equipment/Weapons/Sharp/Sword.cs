namespace Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE = 2;
        public Sword()
            : this(DEFAULT_DAMAGE)
        { }

        public Sword(int damage)
        {
            this.Damage = damage;
        }

        public void Bloodthirst() { }
    }
}
