using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        public int level;
        public int abilityPoints;
        public int healthPoints;
        public string name;
        public string faction;
        public Chainlink bodyArmor;
        public Axe weapon;

        public Warrior() { }

        public void Strike() { }
        public void Execute() { }
        public void SkinHarden() { }
    }
}
