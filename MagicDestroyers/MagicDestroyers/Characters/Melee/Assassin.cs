using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;

namespace Characters.Melee
{
    public class Assassin : Melee
    {
        private const string DEFAULT_NAME = "Dark Ninja";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_ABILITY_POINTS)
        {
            base.Armor = new LightLeatherVest();
            base.Weapon = new Sword();
        }

        public override void Attack()
        {
            this.Raze();
        }

        public override void SpecialAttack()
        {
            this.BleedToDeath();
        }

        public override void Defend()
        {
            this.Survival();
        }

        private void Raze() { }
        private void BleedToDeath() { }
        private void Survival() { }
    }
}
