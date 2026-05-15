using System;

namespace Deconstruction.Examples
{
    // =========================================================
    // 1. THE CUSTOM CLASS
    // =========================================================
    public class Employee
    {
        public string FullName;
        public string JobTitle;
        public int Salary;

        // Standard Constructor (To create the object)
        public Employee(string name, string title, int salary)
        {
            FullName = name;
            JobTitle = title;
            Salary = salary;
        }

        // ---------------------------------------------------------
        // THE MAGIC DECONSTRUCT METHOD
        // It uses 'out' to push data back to the user!
        // ---------------------------------------------------------
        public void Deconstruct(out string nameOut, out string titleOut, out int salaryOut)
        {
            nameOut = this.FullName;
            titleOut = this.JobTitle;
            salaryOut = this.Salary;
        }
    }

    // =========================================================
    // 2. THE MAIN PROGRAM TO TEST IT
    // =========================================================
    public class ClassDeconstructionDemo
    {
        public static void RunObjectDeconstruction()
        {
            Console.WriteLine("=== 4.1 OBJECT DECONSTRUCTION ===\n");

            // 1. Create a normal Object
            Employee dev = new Employee("Alex", "Software Engineer", 85000);

            // 2. Unpack it using Deconstruction!
            // C# sees this, and secretly runs: dev.Deconstruct(out name, out job, out pay);
            var (name, job, pay) = dev;

            Console.WriteLine($"Unpacked Data -> Name: {name}, Job: {job}, Salary: ${pay}");

            // 3. We can even use the Discard symbol (_) on objects!
            // If we only want the Name and Salary:
            var (onlyName, _, onlySalary) = dev;
            
            Console.WriteLine($"\nUsing Discard -> Name: {onlyName}, Salary: ${onlySalary}");

            Console.WriteLine();
        }
    }
}