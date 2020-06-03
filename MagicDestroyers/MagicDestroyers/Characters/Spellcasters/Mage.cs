using Equipment.Armors.Cloth;
using Equipment.Weapons.Blunt;

namespace Characters.Spellcasters
{
    public class Mage : SpellcasterBase
    {
        private const string DEFAULT_NAME = "Ice Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_MANA_POINTS = 100;

        public ClothRobe bodyArmor;
        public Staff weapon;

        public ClothRobe BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Staff Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

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
            this.BodyArmor = new ClothRobe();
            this.Weapon = new Staff();
        }

        public void ArcaneWrath() { }
        public void Firewall() { }
        public void Meditation() { }

    }
}
