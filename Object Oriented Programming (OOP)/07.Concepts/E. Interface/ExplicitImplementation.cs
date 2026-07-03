using System;

namespace Concepts.InterfaceDemo;

public interface IFile
{
    void Save();
}

public interface IDatabase
{
    void Save();
}

// The Storage class uses both interfaces. 
// Both interfaces have a Save() method. This is a naming conflict!
public class Storage : IFile, IDatabase
{
    // EXPLICIT IMPLEMENTATION
    // We remove the 'public' keyword and put the Interface Name in front.

    void IFile.Save()
    {
        Console.WriteLine("Saving data to a Text File...");
    }

    void IDatabase.Save()
    {
        Console.WriteLine("Saving data to the SQL Database...");
    }
}