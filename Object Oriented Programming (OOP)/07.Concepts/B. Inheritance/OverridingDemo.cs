using System;

namespace Concepts.InheritanceDemo;

// PARENT
public class Monster
{
    // 'virtual' means: "My children are allowed to change this!"
    public virtual void Attack()
    {
        Console.WriteLine("The monster hits you normally.");
    }
}

// CHILD
public class Dragon : Monster
{
    // 'override' means: "I am crushing my parent's code and using my own!"
    public override void Attack()
    {
        Console.WriteLine("The dragon breathes massive FIRE! Burn!");
    }
}