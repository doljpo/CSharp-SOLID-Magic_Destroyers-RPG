using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;
using System;

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

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }

        private int ShadowRage()
        {
            return this.Weapon.Damage + 5;
        }
        private int VampireTouch()
        {
            return this.Weapon.Damage + 10;
        }
        private int BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
