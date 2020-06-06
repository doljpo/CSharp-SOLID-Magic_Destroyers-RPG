using Equipment.Armors.Cloth;
using Equipment.Weapons.Blunt;

namespace Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private const string DEFAULT_NAME = "Ice Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_MANA_POINTS = 100;

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_MANA_POINTS)
        {            
            base.Armor = new ClothRobe();
            base.Weapon = new Staff();
        }

        public override void Attack()
        {
            this.ArcaneWrath();
        }

        public override void SpecialAttack()
        {
            this.Firewall();
        }

        public override void Defend()
        {
            this.Meditation();
        }

        private void ArcaneWrath() { }
        private void Firewall() { }
        private void Meditation() { }

    }
}
