using System;

class Program
{
    static void Main(string[] args)
    {
        // Order #1 (USA customer)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", 101, 999.99f, 1),
            new Product("Mouse", 102, 25.50f, 2)
        };
        Order order1 = new Order(products1, customer1);


        // Order #2 (International customer)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Headphones", 201, 75.00f, 1),
            new Product("Keyboard", 202, 45.00f, 1),
            new Product("Monitor", 203, 150.00f, 2)
        };
        Order order2 = new Order(products2, customer2);


        // Print info for each order
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine($"Order Total: ${order1.TotalPrice()}\n");
        Console.WriteLine(order1.GenerateShippingLabel());
        
        Console.WriteLine("\n---------------------");  // Separate orders

        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine($"Order Total: ${order2.TotalPrice()}\n");
        Console.WriteLine(order2.GenerateShippingLabel());
    }
}