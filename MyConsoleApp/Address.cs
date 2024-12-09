using System;

public class Address
{
    // Egenskaper för adressen
    public string Street { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    // Konstruktor för att skapa en adress
    public Address(string street, string city, string postalCode, string country)
    {
        Street = street;
        City = city;
        PostalCode = postalCode;
        Country = country;
    }

    // Metod för att skriva ut adressen på ett lättläst sätt
    public void DisplayAddress()
    {
        Console.WriteLine($"{Street}, {City}, {PostalCode}, {Country}");
    }
}
