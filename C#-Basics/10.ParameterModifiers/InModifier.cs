namespace ParameterModifiers.InModifier
{
    class InMdf
    {
        // 1. Main Execution Method eka (Oya dila thibba entry point eka)
        public static void InModifierDemo()
        {
            Console.WriteLine("--- Testing the 'in' Modifier (View-Only Shield) ---");

            // Original Variable eka hadanawa
            int playerBankBalance = 5000;

            Console.WriteLine("Before Method: Balance is " + playerBankBalance);

            // Method ekata pass karaddi 'in' keyword eka use karanawa.
            // Meken kiyanne "Original eka ganna, habai eka protect karanna" kiyana ekayi.
            CheckBalance(in playerBankBalance);

            Console.WriteLine("After Method: Balance is safely " + playerBankBalance);
        }


        // 2. The Protected Method
        // Parameter eka issaraha 'in' dapu nisa, me method ekata 'balance' eka Read-Only wenawa.
        public static void CheckBalance(in int balance)
        {
            // ✅ ALLOWED: Value eka Read karanna (balanna) puluwan
            Console.WriteLine("Inside Method: The computer sees the balance is " + balance);

            // ❌ NOT ALLOWED: Value eka Change karanna baha!
            // Me pahala thiyena line eke comment marks (//) ain kaloth, 
            // Compiler eka "CS8331" kiyana Error eka denawa.
            // Eken kiyanne "Cannot assign to variable 'in int' because it is a readonly variable" kiyala.

            // balance = 0;  <--- HACKER ATTEMPT BLOCKED!
        }
    }
}