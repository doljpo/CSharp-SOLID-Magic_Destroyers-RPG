using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin
    {
        private int level;
        private int abilityPoints;
        private int healthPoints;
        private string name;
        private string faction;
        public LightLeatherVest bodyArmor;
        public Sword weapon;

        public int Level
        {
            get => level;
            set
            {
                if (value > 0)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentException("Level must be greater than 0.");
                }
            }
        }

        public int AbilityPoints
        {
            get => abilityPoints;
            set
            {
                if (value >= 15 && value <= 20)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Assassins must have Ability points between 15 and 20.");
                }
            }
        }

        public int HealthPoints
        {
            get => healthPoints;
            set
            {
                if (value > 0)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentException("Health points must be greater than 0.");
                }
            }
        }

        public string Name
        {
            get => name;
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
                    name = value;
                }
            }
        }

        public string Faction
        {
            get => faction;
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
                    faction = value;
                }
            }
        }

        public LightLeatherVest BodyArmor
        {
            get => bodyArmor;
            set => bodyArmor = value;
        }

        public Sword Weapon
        {
            get => weapon;
            set => weapon = value;
        }

        public Assassin() { }

        public void Raze() { }
        public void BleedToDeath() { }
        public void Survival() { }
    }
}
