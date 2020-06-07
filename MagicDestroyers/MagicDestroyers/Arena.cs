using Characters;
using Characters.Melee;
using Characters.Spellcasters;
using System;
using System.Collections.Generic;
using Utils;

namespace MagicDestroyers
{
    class Arena
    {
        static void Main(string[] args)
        {
            var rng = new Random();
            var currentMelee = 0;
            var currentSpellcaster = 0;
            var gameOver = false;
            var meleeTeam = new List<Melee>();
            var spellcastersTeam = new List<Spellcaster>();
            var characters = GetCharacters();

            foreach (var character in characters)
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

            currentMelee = rng.Next(0, meleeTeam.Count);
            currentSpellcaster = rng.Next(0, spellcastersTeam.Count);

            while (!gameOver)
            {
                spellcastersTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name, meleeTeam[currentMelee].GetType().ToString());

                if (!spellcastersTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellcastersTeam.Remove(spellcastersTeam[currentSpellcaster]);

                    if (spellcastersTeam.Count == 0)
                    {
                        Colors.ColorfulWriteLine("\nMelee team wins!", ConsoleColor.Red);                        
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellcastersTeam.Count);
                    }
                }

                meleeTeam[currentMelee].TakeDamage(spellcastersTeam[currentSpellcaster].Attack(), spellcastersTeam[currentSpellcaster].Name, spellcastersTeam[currentSpellcaster].GetType().ToString());

                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellcastersTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count == 0)
                    {
                        Colors.ColorfulWriteLine("\nSpell team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }
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
