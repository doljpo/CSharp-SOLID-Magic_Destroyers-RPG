using Characters;
using Characters.Melee;
using Characters.Spellcasters;
using System.Collections.Generic;

namespace MagicDestroyers
{
    class Arena
    {
        static void Main(string[] args)
        {
            var meleeTeam = new List<Melee>();
            var spellcastersTeam = new List<Spellcaster>();

            foreach (var character in GetCharacters())
            {                
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else
                {
                    spellcastersTeam.Add((Spellcaster)character);
                }
            }

            System.Console.WriteLine("Melee Team");
            System.Console.WriteLine("----------");
            foreach (var melee in meleeTeam)
            {
                System.Console.WriteLine(" > " + melee.Name);
            }

            System.Console.WriteLine("");
            System.Console.WriteLine("Spellcasters Team");
            System.Console.WriteLine("-----------------");
            foreach (var spellcaster in spellcastersTeam)
            {
                System.Console.WriteLine(" > " + spellcaster.Name);
            }

            System.Console.ReadKey();
        }

        private static List<Character> GetCharacters()
        {
            return new List<Character>()
            {
                new Assassin(),
                new Druid(),
                new Knight(),
                new Mage(),
                new Necromancer(),
                new Warrior()
            };
        }
    }
}
