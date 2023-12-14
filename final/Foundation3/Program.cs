using System;

class Program
{
    static void Main()
    {
        // Creating address
        var eventAddress = new Address
        {
            Street = "456 Park Ave",
            City = "Cityville",
            StateProvince = "CA",
            Country = "USA"
        };

        // Creating events
        var genericEvent = new Event("Generic Event", "An event for testing", DateTime.Now, TimeSpan.FromHours(2), eventAddress);
        var lectureEvent = new Lecture("Tech Talk", "An informative session on technology", DateTime.Now.AddDays(7), TimeSpan.FromHours(3), eventAddress, "John Doe", 50);
        var receptionEvent = new Reception("Networking Night", "A casual networking event", DateTime.Now.AddDays(14), TimeSpan.FromHours(2), eventAddress, "rsvp@example.com");
        var outdoorEvent = new OutdoorGathering("Park Picnic", "A fun picnic in the park", DateTime.Now.AddDays(21), TimeSpan.FromHours(4), eventAddress, "Sunny with a chance of rain");

        // Displaying event details
        DisplayEventDetails(genericEvent);
        DisplayEventDetails(lectureEvent);
        DisplayEventDetails(receptionEvent);
        DisplayEventDetails(outdoorEvent);
    }

    static void DisplayEventDetails(Event eventInstance)
    {
        Console.WriteLine("------------");
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventInstance.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(eventInstance.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(eventInstance.GetShortDescription());
        Console.WriteLine("------------\n");
    }
}
