using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;
using System;

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

        public override int Attack()
        {
            return this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }

        private int Raze()
        {
            return this.Weapon.Damage + 5;
        }
        private int BleedToDeath()
        {
            return this.Weapon.Damage + 10;
        }
        private int Survival()
        {
            throw new NotImplementedException();
        }
    }
}
