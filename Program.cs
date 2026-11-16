/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: Week 1 console application demonstrating welcome messages,
inheritance, composition, object creation, and formatted output.
The interactive menu is planned for a later project week.
*/
using System;
using System.Collections.Generic;

namespace RolodexContacts;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("====================================================");
        Console.WriteLine("          ROLODEX CONTACTS APPLICATION");
        Console.WriteLine("                  Project Week 1");
        Console.WriteLine("                  Cora Germany");
        Console.WriteLine("====================================================");
        Console.WriteLine("Welcome to your Rolodex!");
        Console.WriteLine("This Week 1 demonstration displays four sample contacts.");
        Console.WriteLine("Future versions will let you add, update, remove,");
        Console.WriteLine("and find contacts by last-name initial.\n");

        // Composition: each Contact receives its own Address object.
        Address businessAddress = new Address("100 Harbor Way", "Newport News", "VA", "23601");
        Address familyAddress = new Address("28 Oak Lane", "Hampton", "VA", "23666");
        Address friendAddress = new Address("17 Pine Street", "Williamsburg", "VA", "23185");
        Address medicalAddress = new Address("55 Wellness Drive", "Newport News", "VA", "23606");

        // Inheritance: these four classes are all derived from Contact.
        List<Contact> contacts = new List<Contact>
        {
            new BusinessContact("Alan", "Brooks", "757-555-0101",
                "alan@example.com", businessAddress, "Harbor Logistics"),
            new FamilyContact("Maria", "Davis", "757-555-0102",
                "maria@example.com", familyAddress, "Cousin"),
            new FriendContact("Janet", "Lewis", "757-555-0103",
                "janet@example.com", friendAddress, "June 12"),
            new MedicalContact("Priya", "Patel", "757-555-0104",
                "priya@example.com", medicalAddress, "Family Medicine")
        };

        Console.WriteLine("SAMPLE CONTACTS (sorted by last name)");
        Console.WriteLine("----------------------------------------------------");
        contacts.Sort((a, b) => string.Compare(a.LastName, b.LastName,
            StringComparison.OrdinalIgnoreCase));

        foreach (Contact contact in contacts)
        {
            // Calls the inherited Contact.ToString() method.
            Console.WriteLine(contact.ToString());
            Console.WriteLine("----------------------------------------------------");
        }
        Console.WriteLine("End of Week 1 demonstration.");
    }
}
