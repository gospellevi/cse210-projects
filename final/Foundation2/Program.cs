using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Phone", "#P001", 1000, 1);
        Product product2 = new Product("Charger", "#P022", 50, 2);
        Product product3 = new Product("Smart Watch", "#P406", 380, 1);
        Product product4 = new Product("Wireless Bud", "#T304", 150, 2);

        // Create addresses
        Address address1 = new Address("525 South Center St", "Rexburg", "ID", "USA");
        Address address2 = new Address("6 Adeniji St", "Ikeja", "LG", "Nigeria");

        // Create customers
        Customer customer1 = new Customer("Chard Markbett", address1);
        Customer customer2 = new Customer("Gospel Levi", address2);

        // Create orders
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product3, product4 });

        // Display order details
        // Console.WriteLine($"Order 1 Total Price: {order1.GetTotalPrice()}\n");
        Console.WriteLine($"Order1 Total Price: {order1.GetTotalPrice()}");
        Console.WriteLine("Order1 Packing Label:");
        Console.WriteLine("=======================");
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine("Order1 Shipping Label:");
        Console.WriteLine("========================");
        Console.WriteLine($"{order1.DisplayShippingLabel()}\n");
        Console.WriteLine();
        Console.WriteLine($"Order2 Total Price: {order2.GetTotalPrice()}");
        Console.WriteLine("Order2 Packing Label:");
        Console.WriteLine("=======================");
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine("Order2 Shipping Label:");
        Console.WriteLine("========================");
        Console.WriteLine(order2.DisplayShippingLabel());
        
    }
}