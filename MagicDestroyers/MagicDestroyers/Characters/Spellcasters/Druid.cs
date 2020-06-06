using Equipment.Armors.Light;
using Equipment.Weapons.Blunt;

namespace Characters.Spellcasters
{
    public class Druid : Spellcaster
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

        public override void Attack()
        {
            this.Moonfire();
        }

        public override void SpecialAttack()
        {
            this.Starburst();
        }

        public override void Defend()
        {
            this.OneWithTheNature();
        }

        private void Moonfire() { }
        private void Starburst() { }
        private void OneWithTheNature() { }
    }
}
