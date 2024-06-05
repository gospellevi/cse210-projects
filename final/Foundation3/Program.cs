using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create address instances
        Address address1 = new Address("6 Adeniji St", "Oregun", "Ikeja", "Lagos");
        Address address2 = new Address("Plot 9B, Block D", "The Sun Estate", "Magboro", "Ogun");
        Address address3 = new Address("6 Opebi Rd", "Opebi", "Ikeja", "Lagos");

        // Create event instances
        Lecture lecture = new Lecture("Advanced C# Programming", "An in-depth look at C# programming.", "2024-08-15", "10:00 AM", address1, "Gospel Levi", 1500);
        Reception reception = new Reception("Annual Gala", "An evening of elegance and networking.", "2024-09-10", "7:00 PM", address2, "Chubbolimited@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Ward Picnic", "A fun day outside.", "2024-07-20", "12:00 PM", address3, "Sunny and warm");

        // Display marketing messages for each event
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("=============================================");
        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("=============================================");

        Console.WriteLine();

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("=============================================");

        Console.WriteLine();
    }
}
