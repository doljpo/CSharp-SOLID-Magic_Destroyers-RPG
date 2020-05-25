using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Spellcasters
{
    public class Necromancer
    {
        private const string DEFAULT_NAME = "Unholy Necromancer";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private int level;
        private int abilityPoints;
        private int healthPoints;
        private string name;
        private Faction faction;
        public LightLeatherVest bodyArmor;
        public Sword weapon;

        public int Level
        {
            get => this.level;
            set
            {
                if (value > 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentException("Level must be greater than 0.");
                }
            }
        }
        public int AbilityPoints
        {
            get => this.abilityPoints;
            set
            {
                if (value >= 8 && value <= 12)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Necromancers must have Ability points between 20 and 30.");
                }
            }
        }
        public int HealthPoints
        {
            get => this.healthPoints;
            set
            {
                if (value > 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentException("Health points must be greater than 0.");
                }
            }
        }
        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The character needs a name.");
                }
                else if (value.Trim().Length < 2 || value.Trim().Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Names must have between 2 and 20 caracters long.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public Faction Faction
        {
            get => this.faction;
            set => this.faction = value;
        }
        public LightLeatherVest BodyArmor
        {
            get => this.bodyArmor;
            set => this.bodyArmor = value;
        }
        public Sword Weapon
        {
            get => this.weapon;
            set => this.weapon = value;
        }

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Necromancer(string name, int level, int healthPoints)
        {
            this.name = name;
            this.level = level;
            this.healthPoints = healthPoints;
            this.abilityPoints = DEFAULT_ABILITY_POINTS;
            this.faction = DEFAULT_FACTION;
            this.bodyArmor = new LightLeatherVest();
            this.weapon = new Sword();
        }

        public void ShadowRage() { }
        public void VampireTouch() { }
        public void BoneShield() { }
    }
}
