using System;

namespace AccessModifiers;

// This is the Base Class (The Parent)
public class ParentClass
{
    // 3. PROTECTED: The Family DNA
    // Only this class and its Children (Derived Classes) can see this variable. Strangers cannot.
    protected string familyName = "The Matrix Family";
}

// This is the Derived Class (The Child). 
// The colon (:) means it inherits from ParentClass.
public class ChildClass : ParentClass
{
    public void ShowFamilyName()
    {
        // SUCCESS: Because this class is a Child, it inherited the protected familyName!
        Console.WriteLine("I am the child. I inherited the protected name: " + familyName);
    }
}