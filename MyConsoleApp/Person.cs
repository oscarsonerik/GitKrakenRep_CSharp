using System;

public class Person
{
    private string name;
    private int age;

    // Egenskaper för personens namn och ålder
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Namn kan inte vara tomt.");
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 120)
                throw new ArgumentOutOfRangeException("Ålder måste vara mellan 0 och 120.");
            age = value;
        }
    }

    // Lägga till en adress för personen
    public Address PersonAddress { get; set; }

    // Konstruktor för att skapa en person
    public Person(string name, int age, Address address)
    {
        Name = name;
        Age = age;
        PersonAddress = address;
    }

    // Metod för att skriva ut personens introduktion
    public void Introduce()
    {
        Console.WriteLine($"Hej, jag heter {Name} och jag är {Age} år gammal.");
    }

    // Metod för att skriva ut personens adress
    public void DisplayAddress()
    {
        Console.WriteLine($"{Name}'s adress:");
        PersonAddress.DisplayAddress();
    }
}
