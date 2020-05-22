using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        public int level;
        public int abilityPoints;
        public int healthPoints;
        public string name;
        public string faction;
        public Chainlink bodyArmor;
        public Hammer weapon;

        public Knight() { }

        public void HolyBlow() { }
        public void PurifySoul() { }
        public void RighteousWings() { }
    }
}
