using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Adress 1
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create Adress 2
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Products
        Product product1 = new Product("Bicycle", "B123", 100);
        Product product2 = new Product("Helmet", "H456", 50);

        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1, 2);
        order1.AddProduct(product2, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1, 3);

        //Order 1
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateTotalCost()}");

        //Order 1 2
        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateTotalCost()}");
    }
}
