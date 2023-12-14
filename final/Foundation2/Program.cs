using System;

class Program
{
    static void Main()
    {
        // Example of creating and displaying orders
        var customer1 = new Customer("John Doe", new Address("123 Main St", "Cityville", "CA", "USA"));
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", 1, 10.99, 2));
        order1.AddProduct(new Product("Gadget", 2, 19.99, 1));

        DisplayOrderDetails(order1);

        var customer2 = new Customer("Jane Smith", new Address("456 Oak St", "Townsville", "NY", "Canada"));
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", 3, 7.99, 3));

        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine($"Packing Label:\n{order.GetPackingLabel()}\n");
        Console.WriteLine($"Shipping Label:\n{order.GetShippingLabel()}\n");
        Console.WriteLine($"Total Price: ${order.GetTotalCost()}\n");
    }
}
