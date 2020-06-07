using Equipment.Armors.Light;
using Equipment.Weapons.Blunt;
using System;
using Utils;

namespace Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        public Druid()
            : this(Consts.Druid.NAME, Consts.LEVEL)
        {
        }

        public Druid(string name, int level)
            : this(name, level, Consts.HEALTH_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.MANA_POINTS)
        {
            base.Armor = new LightLeatherVest();
            base.Weapon = new Staff();
        }

        public override int Attack()
        {
            return this.Weapon.Damage + this.Moonfire();
        }

        public override int SpecialAttack()
        {
            return this.Weapon.Damage + this.Starburst();
        }
        
        private int Moonfire()
        {
            return Consts.BASIC_ATTACK;
        }
        private int Starburst()
        {
            return Consts.SPECIAL_ATTACK;
        }
        private int OneWithTheNature()
        {
            throw new NotImplementedException();
        }
    }
}
