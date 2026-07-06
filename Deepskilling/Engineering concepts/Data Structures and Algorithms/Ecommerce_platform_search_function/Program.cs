using System;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Phone","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Book","Education")
        };

        int searchId = 103;

        Console.WriteLine("Linear Search:");

        Product? result = SearchAlgorithms.LinearSearch(products, searchId);

        if (result != null)
            Console.WriteLine($"{result.ProductName} found.");
        else
            Console.WriteLine("Product not found.");

        Console.WriteLine();

        Console.WriteLine("Binary Search:");

        result = SearchAlgorithms.BinarySearch(products, searchId);

        if (result != null)
            Console.WriteLine($"{result.ProductName} found.");
        else
            Console.WriteLine("Product not found.");
    }
}