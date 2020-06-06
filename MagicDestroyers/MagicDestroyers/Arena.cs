using Characters.Melee;
using Characters.Spellcasters;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class Arena
    {
        static void Main(string[] args)
        {
            // Melee Team
            Melee assassin = new Assassin();
            Melee knight = new Knight();
            Melee warrior = new Warrior();

            List<Melee> meleeTeam = new List<Melee>();
            meleeTeam.Add(assassin);
            meleeTeam.Add(knight);
            meleeTeam.Add(warrior);

            // Spellcaster Team
            Spellcaster druid = new Druid();
            Spellcaster mage = new Mage();
            Spellcaster necromancer = new Necromancer();

            List<Spellcaster> spellcasterTeam = new List<Spellcaster>();
            spellcasterTeam.Add(druid);
            spellcasterTeam.Add(mage);
            spellcasterTeam.Add(necromancer);

            spellcasterTeam[2].Attack();

            System.Console.ReadKey();
        }
    }
}
