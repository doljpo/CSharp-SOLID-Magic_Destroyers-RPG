﻿using Enums;
using Equipment.Armors;
using Equipment.Weapons;
using System;

namespace Characters.Melee
{
    public class Assassin : MeleeBase
    {
        private const string DEFAULT_NAME = "Dark Ninja";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 500;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private int abilityPoints;
        public LightLeatherVest bodyArmor;
        public Sword weapon;

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

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {
        }

        public Assassin(string name, int level, int healthPoints)
            : base(name, level, healthPoints, DEFAULT_FACTION)
        {
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.BodyArmor = new LightLeatherVest();
            this.Weapon = new Sword();
        }

        public void Raze() { }
        public void BleedToDeath() { }
        public void Survival() { }
    }
}
