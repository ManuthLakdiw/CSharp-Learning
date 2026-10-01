using System;

namespace DelegatesDemo;

// 1. DEFINE THE DELEGATE (The Rulebook)
// Rule: The method must return 'void' and take one 'string' parameter.
public delegate void NotificationDelegate(string message);

public class DownloadManager
{
    // 2. USE DELEGATE AS A PARAMETER
    // This method doesn't know HOW to notify the user. It just asks for a method!
    public void DownloadFile(NotificationDelegate onCompleteMethod)
    {
        Console.WriteLine("Worker: Downloading file... Please wait.");
        
        // Simulating the download finish...
        
        // 3. EXECUTE THE DELEGATE
        // This runs whatever method was passed into it!
        onCompleteMethod("The file 'Game.exe' has been downloaded!");
    }
}