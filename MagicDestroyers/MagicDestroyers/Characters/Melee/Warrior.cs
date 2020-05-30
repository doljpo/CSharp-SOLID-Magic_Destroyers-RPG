using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Melee
{
    public class Warrior : MeleeBase
    {
        private const string DEFAULT_NAME = "Brave Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private int abilityPoints;
        public Chainlink bodyArmor;
        public Axe weapon;

        public Chainlink BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Axe Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_FACTION)
        {
            this.abilityPoints = DEFAULT_ABILITY_POINTS;
            this.bodyArmor = new Chainlink();
            this.weapon = new Axe();
        }

        public void Strike() { }
        public void Execute() { }
        public void SkinHarden() { }
    }
}
