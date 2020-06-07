using Equipment.Armors.Light;
using Equipment.Weapons.Blunt;
using System;

namespace Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Wise Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_MANA_POINTS = 100;

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
            base.Armor = new LightLeatherVest();
            base.Weapon = new Staff();
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }
        
        private int Moonfire()
        {
            return this.Weapon.Damage + 5;
        }
        private int Starburst()
        {
            return this.Weapon.Damage + 10;
        }
        private int OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
