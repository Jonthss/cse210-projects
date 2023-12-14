public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}
