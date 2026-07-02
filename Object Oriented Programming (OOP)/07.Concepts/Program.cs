using System;
using Concepts.EncapsulationDemo;

namespace Concepts;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== ENCAPSULATION DEMO ===\n");

        // ---------------------------------------------------------
        // CONCEPT 1: Full Encapsulation & Validation (Student.cs)
        // ---------------------------------------------------------
        Console.WriteLine("--- 1. Testing Student (Validation) ---");
        Student myStudent = new Student();
        
        myStudent.Age = 20; // This is a safe number, it will be saved.
        Console.WriteLine("Student Age is: " + myStudent.Age);
        
        // Let's try to break it with a negative number!
        myStudent.Age = -5; // This triggers the Validation Error message!


        // ---------------------------------------------------------
        // CONCEPT 2: The Short Way (Car.cs)
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 2. Testing Car (Auto-Properties) ---");
        Car myCar = new Car();
        myCar.Color = "Red"; // Very easy to read and write
        
        Console.WriteLine($"My car is a {myCar.Color} {myCar.Model}");


        // ---------------------------------------------------------
        // CONCEPT 3: Real World ATM (BankAccount.cs)
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 3. Testing Bank Account (Real-World) ---");
        BankAccount myAccount = new BankAccount();

        // ERROR: If you remove the // below, the program will crash!
        // You cannot steal money because the 'set' is private!
        // myAccount.Balance = 1000000; 

        // You MUST use the safe ATM methods to change the money:
        myAccount.Deposit(500);
        myAccount.Withdraw(100);
        myAccount.Withdraw(900); // This will fail safely because of our rules!

        Console.WriteLine("\nAll concepts tested successfully!");
    }
}