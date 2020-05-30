using Equipment.Armors;
using Equipment.Weapons;

namespace Characters.Spellcasters
{
    public class Druid : SpellcasterBase
    {
        private const string DEFAULT_NAME = "Wise Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_MANA_POINTS = 100;

        public LightLeatherVest bodyArmor;
        public Staff weapon;

        public LightLeatherVest BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Staff Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_MANA_POINTS)
        {
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Staff();
        }

        public void Moonfire() { }
        public void Starburst() { }
        public void OneWithTheNature() { }
    }
}
