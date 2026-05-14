using System;

namespace ParameterModifiers.RefModifier
{
    class RefMdf
    {
        // 1. The Main Execution Method
        public static void RefModifierDemo()
        {
            Console.WriteLine("--- Testing the 'ref' Keyword ---");

            // RULE 1: We MUST give it a starting value before we use 'ref'.
            int playerHealth = 100; 

            Console.WriteLine("Before Method: Player Health is " + playerHealth);

            // RULE 2: We MUST type 'ref' when we call the method.
            // This sends the ORIGINAL variable, not a copy!
            TakeDamage(ref playerHealth); 

            // Because we used 'ref', the original variable was permanently changed!
            Console.WriteLine("After Method: Player Health is now " + playerHealth);
        }


        // 2. The Modifier Method
        // We type 'ref' here to tell the method to expect the original variable.
        public static void TakeDamage(ref int hp)
        {
            // We subtract 20 from 'hp'. 
            // Because of 'ref', this directly attacks 'playerHealth' in the Main method!
            hp -= 20; 
            
            Console.WriteLine("Inside Method: The player just took 20 damage!");
        }
    }
}