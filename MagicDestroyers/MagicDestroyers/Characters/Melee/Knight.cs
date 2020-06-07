using Equipment.Armors;
using Equipment.Armors.Heavy;
using Equipment.Weapons.Blunt;
using System;
using Utils;

namespace Characters.Melee
{
    public class Knight : Melee
    {
        public Knight()
            : this(Consts.Knight.NAME, Consts.LEVEL)
        {
        }

        public Knight(string name, int level)
            : this(name, level, Consts.HEALTH_POINTS)
        {
        }

        public Knight(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.ABILITY_POINTS)
        {
            base.Armor = new Chainlink();
            base.Weapon = new Hammer();
        }

        public override int Attack()
        {
            return this.Weapon.Damage + this.HolyBlow();
        }

        public override int SpecialAttack()
        {
            return this.Weapon.Damage + this.PurifySoul();
        }

        private int HolyBlow()
        {
            return Consts.BASIC_ATTACK;
        }
        private int PurifySoul()
        {
            return Consts.SPECIAL_ATTACK;
        }
        private int RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
