using Characters.Melee;

namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {
            Assassin ninja = new Assassin();
            Assassin ninja2 = new Assassin("White Ninja", 10);
            Assassin ninja3 = new Assassin("Red Ninja", 13, 999);
        }
    }
}
