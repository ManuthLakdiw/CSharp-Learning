namespace AccessModifiers;

// 4. INTERNAL: The Office Building
// Only classes inside this specific Project (.csproj file) can see this class.
// If someone downloads this project and links it to theirs, they cannot see this.
internal class InternalExample
{
    public string projectSecret = "Only people working in this project can read this.";
}