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

        public LightLeatherVest bodyArmor;
        public Sword weapon;

        public LightLeatherVest BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Sword Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

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
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
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

        private void ShadowRage() { }
        private void VampireTouch() { }
        private void BoneShield() { }
    }
}
