using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
        public int level;
        public int abilityPoints;
        public int healthPoints;
        public string name;
        public string faction;
        public LightLeatherVest bodyArmor;
        public Staff weapon;

        public Druid() { }

        public void Moonfire() { }
        public void Starburst() { }
        public void OneWithTheNature() { }
    }
}
