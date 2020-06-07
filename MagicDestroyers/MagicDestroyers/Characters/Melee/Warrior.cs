using Equipment.Armors.Heavy;
using Equipment.Weapons.Sharp;
using System;
using Utils;

namespace Characters.Melee
{
    public class Warrior : Melee
    {
        public Warrior()
            : this(Consts.Warrior.DEFAULT_NAME, Consts.DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, Consts.DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.DEFAULT_ABILITY_POINTS)
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
            return Consts.DEFAULT_BASIC_ATTACK;
        }
        private int Execute()
        {
            return Consts.DEFAULT_SPECIAL_ATTACK;
        }
        private int SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
