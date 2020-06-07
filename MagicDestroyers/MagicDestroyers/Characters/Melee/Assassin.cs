using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;
using System;
using Utils;

namespace Characters.Melee
{
    public class Assassin : Melee
    {
        public Assassin()
            : this(Consts.Assassin.NAME, Consts.LEVEL)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, Consts.HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.ABILITY_POINTS)
        {
            base.Armor = new LightLeatherVest();
            base.Weapon = new Sword();
        }

        public override int Attack()
        {
            return this.Weapon.Damage + this.Raze();
        }

        public override int SpecialAttack()
        {
            return this.Weapon.Damage + this.BleedToDeath();
        }

        private int Raze()
        {
            return Consts.BASIC_ATTACK;
        }
        private int BleedToDeath()
        {
            return Consts.SPECIAL_ATTACK;
        }
        private int Survival()
        {
            throw new NotImplementedException();
        }
    }
}
