using Equipment.Armors.Heavy;
using Equipment.Weapons.Sharp;
using System;

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

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        private int Strike()
        {
            return this.Weapon.Damage + 5;
        }
        private int Execute()
        {
            return this.Weapon.Damage + 10;
        }
        private int SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
