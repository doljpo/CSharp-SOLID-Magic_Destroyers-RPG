using Equipment.Armors.Light;
using Equipment.Weapons.Sharp;
using System;
using Utils;

namespace Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        public Necromancer()
            : this(Consts.Necromancer.NAME, Consts.LEVEL)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, Consts.HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.MANA_POINTS)
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
            return Consts.BASIC_ATTACK;
        }
        private int VampireTouch()
        {
            return Consts.SPECIAL_ATTACK;
        }
        private int BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
