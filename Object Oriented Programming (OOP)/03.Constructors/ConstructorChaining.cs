using System;

namespace Constructors
{
    public class UserAccount
    {
        public string Username;
        public string Email;
        public int Age;

        // =========================================================
        // THE MASTER CONSTRUCTOR (Constructor 3)
        // This is the ONLY constructor that actually saves the data.
        // =========================================================
        public UserAccount(string username, string email, int age)
        {
            Username = username;
            Email = email;
            Age = age;
            Console.WriteLine($"[Master Builder] Saved: {Username}, {Email}, Age {Age}");
        }

        // =========================================================
        // CONSTRUCTOR 2 (Chains to Master)
        // User only gives Name and Email. We provide a default age of 18!
        // =========================================================
        public UserAccount(string username, string email) : this(username, email, 18)
        {
            Console.WriteLine("[Helper Builder 2] Added default age (18) and chained to Master.");
        }

        // =========================================================
        // CONSTRUCTOR 1 (Chains to Constructor 2)
        // User only gives Name. We provide a default Email!
        // Notice: This chains to Constructor 2, which then chains to Master!
        // =========================================================
        public UserAccount(string username) : this(username, "No Email Provided")
        {
            Console.WriteLine("[Helper Builder 1] Added default email and chained to Builder 2.");
        }
    }

    // =========================================================
    // THE MAIN PROGRAM
    // =========================================================
    public class ConstructorChainingDemo
    {
        public static void RunDemo()
        {
            Console.WriteLine("=== CONSTRUCTOR CHAINING (Without Primary Constructors) ===\n");

            Console.WriteLine("--- Test 1: Only providing Username ---");
            // This will hit Constructor 1 -> Constructor 2 -> Master
            UserAccount u1 = new UserAccount("Manuth");

            Console.WriteLine("\n--- Test 2: Providing Username and Email ---");
            // This will hit Constructor 2 -> Master
            UserAccount u2 = new UserAccount("Alex", "alex@gmail.com");

            Console.WriteLine("\n--- Test 3: Providing Everything ---");
            // This hits the Master directly!
            UserAccount u3 = new UserAccount("ProGamer", "pro@game.com", 25);

            Console.WriteLine();
        }
    }
}