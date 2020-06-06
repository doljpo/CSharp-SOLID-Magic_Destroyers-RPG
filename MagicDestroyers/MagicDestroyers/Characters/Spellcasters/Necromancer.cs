using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;

namespace Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Unholy Necromancer";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_MANA_POINTS = 100;

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_MANA_POINTS)
        {
            base.Armor = new LightLeatherVest();
            base.Weapon = new Sword();
        }

        public override void Attack()
        {
            this.ShadowRage();
        }

        public override void SpecialAttack()
        {
            this.VampireTouch();
        }

        public override void Defend()
        {
            this.BoneShield();
        }

        private void ShadowRage()
        {
            System.Console.WriteLine("Shadow Rage!!");
        }
        private void VampireTouch() { }
        private void BoneShield() { }
    }
}
