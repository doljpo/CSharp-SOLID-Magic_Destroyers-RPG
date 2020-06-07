using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;
        private Armor armor;
        private Weapon weapon;

        public int ManaPoints
        {
            get => this.manaPoints;
            set
            {
                if (value > 0)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentException("Mana points must be greater than 0.");
                }
            }
        }
        public Armor Armor
        {
            get => this.armor;
            set => this.armor = value;
        }
        public Weapon Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Spellcaster(string name, int level, int healthPoints, int manaPoints)
            : base(name, level, healthPoints, Faction.Spellcaster)
        {
            this.ManaPoints = manaPoints;
        }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override int SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override int Defend()
        {
            return this.Armor.ArmorPoints;
        }
    }
}
