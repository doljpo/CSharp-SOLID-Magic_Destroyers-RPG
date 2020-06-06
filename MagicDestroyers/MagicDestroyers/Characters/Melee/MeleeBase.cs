using Enums;
using System;

namespace Characters.Melee
{
    public class MeleeBase : Character
    {
        private const int DEFAULT_ABILITY_POINTS = 100;

        private int abilityPoints;

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

        public MeleeBase(string name, int level, int healthPoints, int abilityPoints)
            : base(name, level, healthPoints, Faction.Melee)
        {
            this.AbilityPoints = abilityPoints;
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
