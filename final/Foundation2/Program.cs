using System;
using System.Collections.Generic;

class Program
{
    class Product
    {
        public string Name { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Country { get; set; }

        public bool IsInUSA()
        {
            return Country.ToLower() == "usa";
        }

        public string GetFullAddress()
        {
            return $"{Street}, {City}, {StateProvince}, {Country}";
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Address CustomerAddress { get; set; }

        public bool IsInUSA()
        {
            return CustomerAddress.IsInUSA();
        }
    }

    class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Customer Customer { get; set; }

        public decimal GetTotalCost()
        {
            decimal totalCost = 0;
            foreach (var product in Products)
            {
                totalCost += product.Price * product.Quantity;
            }

            totalCost += Customer.IsInUSA() ? 5 : 35; // Shipping cost based on location
            return totalCost;
        }

        public string GetPackingLabel()
        {
            var packingLabel = "Packing Label:\n";
            foreach (var product in Products)
            {
                packingLabel += $"{product.Name} - Product ID: {product.ProductID}\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            var shippingLabel = $"Shipping Label:\n{Customer.Name}\n{Customer.CustomerAddress.GetFullAddress()}";
            return shippingLabel;
        }
    }

    static void Main()
    {
        // Creating products
        var product1 = new Product { Name = "Laptop", ProductID = 1, Price = 800, Quantity = 2 };
        var product2 = new Product { Name = "Headphones", ProductID = 2, Price = 50, Quantity = 3 };

        // Creating customer and address
        var customerAddress = new Address
        {
            Street = "123 Main St",
            City = "Cityville",
            StateProvince = "CA",
            Country = "USA"
        };

        var customer = new Customer { Name = "John Doe", CustomerAddress = customerAddress };

        // Creating an order
        var order = new Order { Products = { product1, product2 }, Customer = customer };

        // Displaying order details
        Console.WriteLine("Order Details:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost()}");
    }
}
