using System;

namespace ErrorHandlingDemo;

// 1. CREATE THE CUSTOM EXCEPTION
// We inherit from 'Exception' and use ': base()' to send the message to the Parent class.
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

// 2. THE BUSINESS LOGIC CLASS
public class BankAccount
{
    private decimal _balance = 500;

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            // THROW OUR CUSTOM EXCEPTION!
            throw new InsufficientFundsException($"Withdrawal failed! You only have ${_balance} in your account.");
        }

        _balance -= amount;
        Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${_balance}");
    }
}

// 3. THE DEMO
public class CustomExceptions
{
    public void RunDemo()
    {
        Console.WriteLine("\n--- 5. Custom Exceptions Demo ---");
        
        BankAccount myAccount = new BankAccount();

        try
        {
            Console.WriteLine("Trying to withdraw $1000 from an account with $500...");
            myAccount.Withdraw(1000); 
        }
        // CATCHING OUR SPECIFIC CUSTOM ERROR
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"[BANK BUSINESS ERROR]: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[SYSTEM ERROR]: {ex.Message}");
        }
    }
}