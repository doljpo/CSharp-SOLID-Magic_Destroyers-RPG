using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Spellcasters
{
    public class Mage : SpellcasterBase
    {
        private const string DEFAULT_NAME = "Ice Mage";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;

        private int abilityPoints;
        public ClothRobe bodyArmor;
        public Staff weapon;

        public ClothRobe BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Staff Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
            : base(name, level, healthPoints)
        {
            this.abilityPoints = DEFAULT_ABILITY_POINTS;
            this.bodyArmor = new ClothRobe();
            this.weapon = new Staff();
        }

        public void ArcaneWrath() { }
        public void Firewall() { }
        public void Meditation() { }

    }
}
