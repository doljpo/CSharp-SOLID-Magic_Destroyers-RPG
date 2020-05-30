using Enums;
using System;

namespace Characters.Spellcasters
{
    public class SpellcasterBase : Character
    {
        private int manaPoints;

        public int ManaPoints
        {
            get => this.manaPoints;
            set
            {
                if (value >= 8 && value <= 12)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Spellcasters must have Mana points between 18 and 25.");
                }
            }
        }

        public SpellcasterBase(string name, int level, int healthPoints)
            : base(name, level, healthPoints, Faction.Spellcaster)
        {
        }
    }
}
