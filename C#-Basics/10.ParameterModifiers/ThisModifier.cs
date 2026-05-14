namespace ParameterModifiers.ThisModifier
{
    // ==========================================
    // 1. OUR CUSTOM CLASS (A normal class)
    // ==========================================
    public class Player
    {
        public string Name;
        public int Health = 100;

        public Player(string name) { Name = name; }
        // The factory didn't give the player a "Heal" method!
    }

    public static class MyCustomPowers
    {
        // Power 1: Adding to a BUILT-IN class (string)
        // We add extra normal parameters too (symbol)
        public static void MakeCool(this string word, string symbol)
        {
            Console.WriteLine(symbol + " " + word + " " + symbol);
        }

        // Power 2: Adding to a CUSTOM class (Player)
        public static void Heal(this Player p, int healAmount)
        {
            p.Health += healAmount;
            Console.WriteLine(p.Name + " healed! Health is now: " + p.Health);
        }
    }
}