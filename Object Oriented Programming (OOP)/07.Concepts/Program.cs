using System;
// using Concepts.EncapsulationDemo;
// using Concepts.InheritanceDemo;
using Concepts.PolymorphismDemo;

namespace Concepts;

class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("=== ENCAPSULATION DEMO ===\n");

        // // ---------------------------------------------------------
        // // CONCEPT 1: Full Encapsulation & Validation (Student.cs)
        // // ---------------------------------------------------------
        // Console.WriteLine("--- 1. Testing Student (Validation) ---");
        // Student myStudent = new Student();
        
        // myStudent.Age = 20; // This is a safe number, it will be saved.
        // Console.WriteLine("Student Age is: " + myStudent.Age);
        
        // // Let's try to break it with a negative number!
        // myStudent.Age = -5; // This triggers the Validation Error message!


        // // ---------------------------------------------------------
        // // CONCEPT 2: The Short Way (Car.cs)
        // // ---------------------------------------------------------
        // Console.WriteLine("\n--- 2. Testing Car (Auto-Properties) ---");
        // Car myCar = new Car();
        // myCar.Color = "Red"; // Very easy to read and write
        
        // Console.WriteLine($"My car is a {myCar.Color} {myCar.Model}");


        // // ---------------------------------------------------------
        // // CONCEPT 3: Real World ATM (BankAccount.cs)
        // // ---------------------------------------------------------
        // Console.WriteLine("\n--- 3. Testing Bank Account (Real-World) ---");
        // BankAccount myAccount = new BankAccount();

        // // ERROR: If you remove the // below, the program will crash!
        // // You cannot steal money because the 'set' is private!
        // // myAccount.Balance = 1000000; 

        // // You MUST use the safe ATM methods to change the money:
        // myAccount.Deposit(500);
        // myAccount.Withdraw(100);
        // myAccount.Withdraw(900); // This will fail safely because of our rules!

        // Console.WriteLine("\nAll concepts tested successfully!");






        // Console.WriteLine("=== C# INHERITANCE DEMO ===\n");

        // // ---------------------------------------------------------
        // // 1. Testing Single Inheritance
        // // ---------------------------------------------------------
        // Console.WriteLine("--- 1. Single Inheritance ---");
        // Son mySon = new Son();
        // Console.WriteLine("My family name is: " + mySon.FamilyName); // Inherited!
        // mySon.Work(); // Inherited!
        // mySon.Play(); // His own method


        // // ---------------------------------------------------------
        // // 2. Testing Multi-Level Inheritance
        // // ---------------------------------------------------------
        // Console.WriteLine("\n--- 2. Multi-Level Inheritance ---");
        // Puppy cutePuppy = new Puppy();
        // cutePuppy.Eat();  // From Grandparent (Animal)
        // cutePuppy.Bark(); // From Parent (Dog)
        // cutePuppy.Weep(); // From Child (Puppy)


        // // ---------------------------------------------------------
        // // 3. Testing Hierarchical Inheritance
        // // ---------------------------------------------------------
        // Console.WriteLine("\n--- 3. Hierarchical Inheritance ---");
        // Car myCar = new Car();
        // Truck myTruck = new Truck();
        
        // myCar.StartEngine(); // Car inherited this
        // myCar.PlayRadio();   // Car's own feature
        
        // myTruck.StartEngine();    // Truck ALSO inherited this!
        // myTruck.CarryHeavyLoad(); // Truck's own feature


        // // ---------------------------------------------------------
        // // 4. Testing Multiple Inheritance (Interfaces)
        // // ---------------------------------------------------------
        // Console.WriteLine("\n--- 4. Multiple Inheritance (Interfaces) ---");
        // Duck donald = new Duck();
        // donald.Fly();  // From IFlyable contract
        // donald.Swim(); // From ISwimmable contract


        // // ---------------------------------------------------------
        // // 5. Testing Overriding (Virtual / Override)
        // // ---------------------------------------------------------
        // Console.WriteLine("\n--- 5. Overriding Parent's Code ---");
        // Monster genericMonster = new Monster();
        // genericMonster.Attack(); // Prints normal attack

        // Dragon bossDragon = new Dragon();
        // bossDragon.Attack(); // Prints the FIRE attack (The overridden version!)


        // Console.WriteLine("\nAll inheritance concepts tested successfully!");

        
        
       Console.WriteLine("=== POLYMORPHISM DEMO ===\n");

        // // ---------------------------------------------------------
        // // 1. RUN-TIME POLYMORPHISM (Upcasting & Overriding)
        // // ---------------------------------------------------------
        // Console.WriteLine("--- 1. Run-Time (Dynamic) Polymorphism ---");
        
        // // SUPER-CLASS REFERENCE = SUB-CLASS OBJECT!
        // Animal myDog = new Dog();
        // Animal myCat = new Cat();

        // // The computer decides which sound to make at Run-Time!
        // myDog.Speak(); // Prints: Woof! Woof!
        // myCat.Speak(); // Prints: Meow! Meow!


        // ---------------------------------------------------------
        // 2. PROPERTY OVERRIDING
        // ---------------------------------------------------------
        Console.WriteLine("\n--- 2. Property Overriding ---");
        NormalBank bank1 = new NormalBank();
        NormalBank bank2 = new PremiumBank(); // Upcasting again!
        
        Console.WriteLine("Normal Bank Rate: " + bank1.InterestRate + "%");
        Console.WriteLine("Premium Bank Rate: " + bank2.InterestRate + "%");

    }
}