using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project."); // Create addresses
       
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple St", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", 1, 3.99, 2));
        order1.AddProduct(new Product("Gadget", 2, 4.99, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", 3, 2.99, 5));
        order2.AddProduct(new Product("Doodad", 4, 1.49, 3));

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.TotalPrice():F2}\n");
    }


}
}