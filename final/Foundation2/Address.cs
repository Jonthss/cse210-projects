class Address
{
    public string Street { get; }
    public string City { get; }
    public string StateProvince { get; }
    public string Country { get; }

    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}
