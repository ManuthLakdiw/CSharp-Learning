using System;

namespace IndexerDemo;

public class Spreadsheet
{
    // A 2D array (Like an Excel sheet with 5 rows and 5 columns)
    private string[,] cells = new string[5, 5];

    // THE INDEXER
    // It takes TWO parameters inside the brackets!
    public string this[int row, int col]
    {
        get 
        { 
            return cells[row, col]; 
        }
        set 
        { 
            cells[row, col] = value; 
        }
    }
}