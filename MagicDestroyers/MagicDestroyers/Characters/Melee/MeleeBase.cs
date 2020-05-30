using Characters;
using Enums;
using System;

namespace Characters.Melee
{
    public class MeleeBase : Character
    {
        private int abilityPoints;

        public MeleeBase(string name, int level, int healthPoints, Faction faction) 
            : base(name, level, healthPoints, faction)
        {
        }

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
    }
}
