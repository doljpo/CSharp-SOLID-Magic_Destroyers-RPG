using Equipment.Armors.Cloth;
using Equipment.Weapons.Blunt;
using System;
using Utils;

namespace Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        public Mage()
            : this(Consts.Mage.NAME, Consts.LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, Consts.HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.MANA_POINTS)
        {            
            base.Armor = new ClothRobe();
            base.Weapon = new Staff();
        }

        public override int Attack()
        {
            return this.Weapon.Damage + this.ArcaneWrath();
        }

        public override int SpecialAttack()
        {
            return this.Weapon.Damage + this.Firewall();
        }
        
        private int ArcaneWrath()
        {
            return Consts.BASIC_ATTACK;
        }
        private int Firewall()
        {
            return Consts.SPECIAL_ATTACK;
        }
        private int Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
