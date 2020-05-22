using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer
    {
        public int level;
        public int abilityPoints;
        public int healthPoints;
        public string name;
        public string faction;
        public LightLeatherVest bodyArmor;
        public Sword weapon;

        public Necromancer() { }

        public void ShadowRage() { }
        public void VampireTouch() { }
        public void BoneShield() { }
    }
}
