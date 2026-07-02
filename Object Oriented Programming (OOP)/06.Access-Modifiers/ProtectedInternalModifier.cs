namespace AccessModifiers;

public class VipParent
{
    // 5. PROTECTED INTERNAL: The VIP Pass
    // This uses TWO rules: 
    // Rule 1: Anyone in the same Project can see it (Internal).
    // Rule 2: Any Child Class in a DIFFERENT project can also see it (Protected).
    protected internal string vipMessage = "Welcome to the VIP Club.";
}