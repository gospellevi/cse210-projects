using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Laptop", "P001", 1000, 1);
        Product product2 = new Product("Mouse", "P002", 50, 2);
        Product product3 = new Product("Keyboard", "P003", 80, 1);

        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product2, product3 });

        // Display order details
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine($"Order 1 Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine($"Order 2 Total Price: ${order2.GetTotalPrice()}");
    }
}