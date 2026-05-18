namespace ThisKeyword
{
    // =========================================================
    // JOB 3: EXTENSION METHOD (Must be in a static class)
    // =========================================================
    public static class StringUpgrades
    {
        public static string AddStars(this string text) // 'this' acts as glue
        {
            return $"*** {text} ***";
        }
    }

    public class MagicBox
    {
        // =========================================================
        // JOB 1: CLASSIC 'this' (Self Reference)
        // =========================================================
        private string hiddenSecret;

        public void SetSecret(string hiddenSecret)
        {
            // 'this.' prevents confusion between the parameter and the field
            this.hiddenSecret = hiddenSecret; 
        }

        // =========================================================
        // JOB 2: CONSTRUCTOR CHAINING
        // =========================================================
        public MagicBox(string secret) 
        { 
            this.hiddenSecret = secret; 
        }

        // Chaining to the main builder above
        public MagicBox() : this("Empty Box") 
        { 
            Console.WriteLine("Default box created!");
        }

        // =========================================================
        // JOB 4: INDEXER
        // =========================================================
        private string[] items = new string[5];

        public string this[int index] // The method name is 'this'
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            // Testing Job 3 (Extension Method)
            string word = "Hello";
            Console.WriteLine(word.AddStars()); // Prints: *** Hello ***

            // Testing Job 2 (Chaining)
            MagicBox box = new MagicBox();

            // Testing Job 4 (Indexer)
            box[0] = "Gold Coin"; // Using the object like an array!
            Console.WriteLine(box[0]);
        }
    }
}