using Equipment.Armors.Heavy;
using Equipment.Weapons.Sharp;

namespace Characters.Melee
{
    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Brave Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_ABILITY_POINTS)
        {
            base.Armor = new Chainlink();
            base.Weapon = new Axe();
        }

        public override void Attack()
        {
            this.Strike();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }

        private void Strike() { }
        private void Execute() { }
        private void SkinHarden() { }
    }
}
