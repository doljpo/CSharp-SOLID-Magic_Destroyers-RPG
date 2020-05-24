using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;

namespace Characters.Spellcasters
{
    public class Mage
    {
        private int level;
        private int abilityPoints;
        private int healthPoints;
        private string name;
        private string faction;
        public ClothRobe bodyArmor;
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
                    throw new ArgumentOutOfRangeException("Mages must have Ability points between 25 and 40.");
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
            : this("Ice Mage", 1)
        {
        }

        public Mage(string name, int level)
            : this(name, level, 500)
        {
        }

        public Mage(string name, int level, int healthPoints)
        {
            this.level = level;
            this.abilityPoints = 100;
            this.healthPoints = healthPoints;
            this.name = name;
            this.faction = "Spellcaster";
            this.bodyArmor = new ClothRobe();
            this.weapon = new Staff();
        }

        public void ArcaneWrath() { }
        public void Firewall() { }
        public void Meditation() { }

    }
}
