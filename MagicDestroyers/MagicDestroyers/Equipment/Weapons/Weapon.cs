﻿using System;

namespace Equipment.Weapons
{
    public class Weapon
    {
        private int damage;

        public int Damage
        {
            get => this.damage;
            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentException("Damage must be greater than 0.");
                }
            }
        }
    }
}
