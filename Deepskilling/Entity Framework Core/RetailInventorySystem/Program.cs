// LAB 4

// using Microsoft.EntityFrameworkCore;

// using var context = new AppDbContext();

// var electronics = new Category { Name = "Electronics" };
// var groceries = new Category { Name = "Groceries" };

// await context.Categories.AddRangeAsync(electronics, groceries);

// var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
// var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

// await context.Products.AddRangeAsync(product1, product2);
// await context.SaveChangesAsync();

// Console.WriteLine("Seed data inserted successfully!");




// LAB 5

using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

// 1. Retrieve All Products
Console.WriteLine("--- All Products ---");
var products = await context.Products.ToListAsync();
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price}");

// 2. Find by ID
Console.WriteLine("\n--- Find by ID ---");
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name}");

// 3. FirstOrDefault with Condition
Console.WriteLine("\n--- Expensive Product ---");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");

