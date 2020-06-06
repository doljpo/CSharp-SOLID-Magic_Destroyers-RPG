using Enums;
using System;

namespace Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;

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

        public Spellcaster(string name, int level, int healthPoints, int manaPoints)
            : base(name, level, healthPoints, Faction.Spellcaster)
        {
            this.ManaPoints = manaPoints;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}
