using System;

namespace Utils
{
    public static class Colors
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case "Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "Characters.Melee.Knight":
                    color = ConsoleColor.Yellow;
                    break;
                case "Characters.Melee.Assassin":
                    color = ConsoleColor.Gray;
                    break;
                case "Characters.Spellcasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                case "Characters.Spellcasters.Necromancer":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "Characters.Spellcasters.Druid":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
