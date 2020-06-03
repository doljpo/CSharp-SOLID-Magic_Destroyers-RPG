namespace Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_DAMAGE = 10;

        public Hammer()
            : this(DEFAULT_DAMAGE)
        { }

        public Hammer(int damage)
        {
            this.Damage = damage;
        }

        public void Stun() { }
    }
}
