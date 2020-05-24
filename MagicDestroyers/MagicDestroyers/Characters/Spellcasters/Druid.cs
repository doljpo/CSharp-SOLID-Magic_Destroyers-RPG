﻿using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;

namespace Characters.Spellcasters
{
    public class Druid
    {
        private int level;
        private int abilityPoints;
        private int healthPoints;
        private string name;
        private string faction;
        public LightLeatherVest bodyArmor;
        public Staff weapon;

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
                    throw new ArgumentOutOfRangeException("Druids must have Ability points between 18 and 25.");
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
        public string Faction
        {
            get => this.faction;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The character needs a faction.");
                }
                else if (value.Trim() != "Melee" && value.Trim() != "Spellcaster")
                {
                    throw new ArgumentOutOfRangeException("Faction must be 'Melee' or 'Spellcaster'");
                }
                else
                {
                    this.faction = value;
                }
            }
        }
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
            : this("Wise Druid", 1)
        {
        }

        public Druid(string name, int level)
            : this(name, level, 500)
        {
        }

        public Druid(string name, int level, int healthPoints)
        {
            this.level = level;
            this.abilityPoints = 100;
            this.healthPoints = healthPoints;
            this.name = name;
            this.faction = "Spellcaster";
            this.bodyArmor = new LightLeatherVest();
            this.weapon = new Staff();
        }

        public void Moonfire() { }
        public void Starburst() { }
        public void OneWithTheNature() { }
    }
}
