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
            var meleeTeam = new List<Melee>();
            var spellTeam = new List<Spellcaster>();

            Melee melee;
            Spellcaster caster;

            foreach (var character in GetCharacters())
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (true)
            {
                GetFighters(rng, meleeTeam, spellTeam, out melee, out caster);

                MeleeAttacks(melee, caster);

                if (!caster.IsAlive)
                {
                    melee.WonBattle();
                    spellTeam.Remove(caster);

                    if (IsTeamDefeated(spellTeam.Count))
                    {
                        AnnounceVictory("Melee");
                        break;
                    }
                }

                CasterAttacks(caster, melee);

                if (!melee.IsAlive)
                {
                    caster.WonBattle();
                    meleeTeam.Remove(melee);

                    if (IsTeamDefeated(meleeTeam.Count))
                    {
                        AnnounceVictory("Spell");
                        break;
                    }
                }
            }

            System.Console.ReadKey();
        }

        private static void GetFighters(Random rng, List<Melee> meleeTeam, List<Spellcaster> spellTeam, out Melee melee, out Spellcaster caster)
        {
            melee = GetMelee(meleeTeam, rng);
            caster = GetCaster(spellTeam, rng);
        }

        private static void CasterAttacks(Spellcaster caster, Melee fighter)
        {
            fighter.TakeDamage(caster.Attack(), caster.Name, caster.GetType().ToString());
        }

        private static void MeleeAttacks(Melee fighter, Spellcaster caster)
        {
            caster.TakeDamage(fighter.Attack(), fighter.Name, fighter.GetType().ToString());
        }

        private static bool IsTeamDefeated(int count)
        {
            return count == 0;
        }

        private static void AnnounceVictory(string team)
        {
            Colors.ColorfulWriteLine($"\n{team} team wins!", ConsoleColor.Red);
        }
        
        private static Melee GetMelee(List<Melee> meleeTeam, Random rng)
        {
            return meleeTeam[rng.Next(0, meleeTeam.Count)];
        }

        private static Spellcaster GetCaster(List<Spellcaster> spellcasterTeam, Random rng)
        {
            return spellcasterTeam[rng.Next(0, spellcasterTeam.Count)];
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
