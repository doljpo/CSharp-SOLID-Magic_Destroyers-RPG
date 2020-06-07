using Equipment.Armors.Heavy;
using Equipment.Weapons.Sharp;
using System;
using Utils;

namespace Characters.Melee
{
    public class Warrior : Melee
    {
        public Warrior()
            : this(Consts.Warrior.NAME, Consts.LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, Consts.HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.ABILITY_POINTS)
        {
            base.Armor = new Chainlink();
            base.Weapon = new Axe();
        }

        public override int Attack()
        {
            return this.Weapon.Damage + this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Weapon.Damage + this.Execute();
        }

        private int Strike()
        {
            return Consts.BASIC_ATTACK;
        }
        private int Execute()
        {
            return Consts.SPECIAL_ATTACK;
        }
        private int SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
