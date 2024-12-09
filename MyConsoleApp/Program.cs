using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapa en adress. Första Address = typen av objekt du skapar
        // address1 är en variabel som innehåller en instans av klassen Address
        // Andra new Address är konstruktorn av Person-klassen för att skapa ett nytt objekt 
        Address address1 = new Address("Gatan 5", "Stockholm", "111 22", "Sverige");

        // Skapa en person och koppla till adressen
        Person person1 = new Person("Alice", 25, address1);

        // Använd metoder för att visa information om personen och deras adress
        person1.Introduce(); // Introducera personen
        person1.DisplayAddress(); // Visa adressen

        // Skapa en annan person med en annan adress
        Address address2 = new Address("Main Street 12", "Göteborg", "411 15", "Sverige");
        Person person2 = new Person("Bob", 30, address2);
        
        // Använd metoder för att visa information om den andra personen
        person2.Introduce();
        person2.DisplayAddress();

        // Vänta på att användaren trycker på en tangent innan programmet avslutas
        Console.WriteLine("Tryck på en valfri tangent för att avsluta...");
        Console.ReadKey();
    }
}
