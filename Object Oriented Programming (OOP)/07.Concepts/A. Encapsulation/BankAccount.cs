using System;

namespace Concepts.EncapsulationDemo;

public class BankAccount
{
    // The Balance is Encapsulated!
    // 'get' is public: Anyone can look at their balance.
    // 'set' is private: You cannot change the balance directly from the outside!
    public double Balance { get; private set; } = 0;

    // To change the balance, you MUST use these safe public methods (like an ATM).
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Deposited: ${amount}. New Balance: ${Balance}");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance = Balance - amount;
            Console.WriteLine($"Withdrew: ${amount}. New Balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Error: You do not have enough money!");
        }
    }
}