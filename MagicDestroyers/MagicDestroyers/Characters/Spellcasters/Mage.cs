using Equipment.Armors.Cloth;
using Equipment.Weapons.Blunt;
using System;
using Utils;

namespace Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        public Mage()
            : this(Consts.Mage.DEFAULT_NAME, Consts.DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, Consts.DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Consts.DEFAULT_MANA_POINTS)
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
            return Consts.DEFAULT_BASIC_ATTACK;
        }
        private int Firewall()
        {
            return Consts.DEFAULT_SPECIAL_ATTACK;
        }
        private int Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
