class Product
{
    public string Name { get; }
    public int ProductId { get; }
    public double Price { get; }
    public int Quantity { get; }

    public Product(string name, int productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}