using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;
using System;
using Utils;

namespace Characters.Melee
{
    public class Assassin : Melee
    {
        public Assassin()
            : this(Consts.Assassin.DEFAULT_NAME, Consts.DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, Consts.DEFAULT_HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.DEFAULT_ABILITY_POINTS)
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
            return Consts.DEFAULT_BASIC_ATTACK;
        }
        private int BleedToDeath()
        {
            return Consts.DEFAULT_SPECIAL_ATTACK;
        }
        private int Survival()
        {
            throw new NotImplementedException();
        }
    }
}
