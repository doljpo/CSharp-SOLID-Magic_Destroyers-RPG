using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;
using System;
using Utils;

namespace Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        public Necromancer()
            : this(Consts.Necromancer.DEFAULT_NAME, Consts.DEFAULT_LEVEL)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.DEFAULT_HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.DEFAULT_MANA_POINTS)
        {
            base.Armor = new LightLeatherVest();
            base.Weapon = new Sword();
        }

        public override int Attack()
        {
            return this.Weapon.Damage + this.ShadowRage();
        }

        public override int SpecialAttack()
        {
            return this.Weapon.Damage + this.VampireTouch();
        }

        private int ShadowRage()
        {
            return Consts.DEFAULT_BASIC_ATTACK;
        }
        private int VampireTouch()
        {
            return Consts.DEFAULT_SPECIAL_ATTACK;
        }
        private int BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
