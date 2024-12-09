﻿using System; // Importerar System-namespace som innehåller grundläggande funktioner som Console.

class Person // Definierar en klass som heter "Person". Detta är en mall för att skapa personobjekt.
{
    // Fält/egenskaper för klassen
    public string Name { get; set; } // En offentlig egenskap för att lagra personens namn (med getter och setter).
    public int Age { get; set; }     // En offentlig egenskap för att lagra personens ålder (med getter och setter).

    // Konstruktor för att skapa nya Person-objekt med namn och ålder
    public Person(string name, int age) 
    {
        Name = name; // Tilldelar värdet av "name" till egenskapen Name.
        Age = age;   // Tilldelar värdet av "age" till egenskapen Age.
    }

    // En metod som beskriver personen
    public void Introduce()
    {
        // Skriver ut en hälsning som innehåller personens namn och ålder.
        Console.WriteLine($"Hej, jag heter {Name} och jag är {Age} år gammal.");
    }
}

class Program // Definierar huvudklassen där programmet startar.
{
    static void Main(string[] args) // Huvudmetoden, startpunkten för programmet.
    {
        // Skapar ett nytt Person-objekt med namnet "Alice" och åldern 25.
        Person person1 = new Person("Alice", 25);

        // Anropar Introduce-metoden för att skriva ut information om personen.
        person1.Introduce();

        // Skapar ett annat Person-objekt med namnet "Bob" och åldern 30.
        Person person2 = new Person("Bob", 30);

        // Anropar Introduce-metoden för att skriva ut information om den andra personen.
        person2.Introduce();

        // Väntar på att användaren trycker på en tangent innan programmet avslutas.
        Console.WriteLine("Tryck på en valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
