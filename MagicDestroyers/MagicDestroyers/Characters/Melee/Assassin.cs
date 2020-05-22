using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin
    {
        public int level;
        public int abilityPoints;
        public int healthPoints;
        public string name;
        public string faction;
        public LightLeatherVest bodyArmor;
        public Sword weapon;

        public Assassin() { }

        public void Raze() { }
        public void BleedToDeath() { }
        public void Survival() { }
    }
}
