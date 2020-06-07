using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Melee
{
    public class Melee : Character
    {
        private int abilityPoints;
        private Armor armor;
        private Weapon weapon;

        public int AbilityPoints
        {
            get => this.abilityPoints;
            set
            {
                if (value > 0)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentException("Ability points must be greater than 0.");
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

        public Melee(string name, int level, int healthPoints, int abilityPoints)
            : base(name, level, healthPoints, Faction.Melee)
        {
            this.AbilityPoints = abilityPoints;
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
