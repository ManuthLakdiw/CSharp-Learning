using System;
using System.Collections.Generic;

namespace IndexerDemo;

public class Library
{
    private List<string> books = new List<string>();

    public void AddBook(string bookName)
    {
        books.Add(bookName);
    }

    // INDEXER 1: Search by ID (Integer)
    public string this[int index]
    {
        get 
        { 
            return books[index]; 
        }
    }

    // INDEXER 2: Search by Name (String)
    // This returns the position (ID) of the book.
    public int this[string bookName]
    {
        get 
        { 
            return books.IndexOf(bookName); 
        }
    }
}