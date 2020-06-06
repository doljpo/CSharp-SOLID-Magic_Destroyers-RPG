using Equipment.Armors;
using Equipment.Armors.Heavy;
using Equipment.Weapons.Blunt;

namespace Characters.Melee
{
    public class Knight : Melee
    {
        private const string DEFAULT_NAME = "Holy Knight";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Knight(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Knight(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_ABILITY_POINTS)
        {
            base.Armor = new Chainlink();
            base.Weapon = new Hammer();
        }

        public override void Attack()
        {
            this.HolyBlow();
        }

        public override void SpecialAttack()
        {
            this.PurifySoul();
        }

        public override void Defend()
        {
            this.RighteousWings();
        }

        private void HolyBlow() { }
        private void PurifySoul() { }
        private void RighteousWings() { }
    }
}
