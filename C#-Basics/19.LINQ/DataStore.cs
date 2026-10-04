using System.Collections.Generic;

namespace LinqDemo;

// We use a Record for simple, immutable data
public record Product(int Id, string Name, string Category, int Price);

public static class DataStore
{
    // A ready-made list of products to use in all our files
    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product(1, "MacBook Pro", "Electronics", 2000),
            new Product(2, "Logitech Mouse", "Electronics", 50),
            new Product(3, "Dell Monitor", "Electronics", 300),
            new Product(4, "Apple", "Food", 2),
            new Product(5, "Pizza", "Food", 15),
            new Product(6, "Desk Chair", "Furniture", 150)
        };
    }
}