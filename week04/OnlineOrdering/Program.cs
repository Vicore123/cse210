using System;

class Program
{
    static void Main(string[] args)
    {
        
        Product product1 = new Product("Laptop", 101, 1200.50f, 2);
        Product product2 = new Product("Mouse", 102, 25.75f);
        
        Product product3 = new Product("Headphones", 201, 85.30f);
        Product product4 = new Product("Keyboard", 202, 45.99f, 3);

        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        
        List<Product> order1Products = new List<Product> { product1, product2 };
        List<Product> order2Products = new List<Product> { product3, product4 };
        
        Order order1 = new Order(order1Products, customer1);
        Order order2 = new Order(order2Products, customer2);
        
        Console.Clear();
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");
        
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}