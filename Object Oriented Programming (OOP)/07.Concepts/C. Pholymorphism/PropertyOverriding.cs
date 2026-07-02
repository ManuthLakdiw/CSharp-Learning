using System;

namespace Concepts.PolymorphismDemo;

public class NormalBank
{
    // We cannot override normal variables, but we CAN override Properties!
    public virtual double InterestRate { get; set; } = 3.0; 
}

public class PremiumBank : NormalBank
{
    // We are overriding the property value!
    public override double InterestRate { get; set; } = 7.5; 
}