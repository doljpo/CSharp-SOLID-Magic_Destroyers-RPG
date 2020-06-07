namespace Equipment.Weapons.Sharp
{
    public class Axe : Sharp
    {
        private const int DEFAULT_DAMAGE = 4;
        public Axe()
            : this (DEFAULT_DAMAGE)
        { }

        public Axe(int damage)
        {
            this.Damage = damage;
        }

        public void HackNSlash() { }
    }
}
