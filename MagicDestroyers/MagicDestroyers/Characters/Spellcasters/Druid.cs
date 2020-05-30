using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Spellcasters
{
    public class Druid : SpellcasterBase
    {
        private const string DEFAULT_NAME = "Wise Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;

        private int abilityPoints;
        public LightLeatherVest bodyArmor;
        public Staff weapon;

        public LightLeatherVest BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Staff Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Druid(string name, int level, int healthPoints)
            : base (name, level, healthPoints)
        {
            this.abilityPoints = DEFAULT_ABILITY_POINTS;
            this.bodyArmor = new LightLeatherVest();
            this.weapon = new Staff();
        }

        public void Moonfire() { }
        public void Starburst() { }
        public void OneWithTheNature() { }
    }
}
