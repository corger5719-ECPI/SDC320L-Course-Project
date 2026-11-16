/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: A family contact with an additional relationship property.
Demonstrates inheritance from Contact.
*/
namespace RolodexContacts;

// Inheritance: FamilyContact IS a Contact.
public class FamilyContact : Contact
{
    public string Relationship { get; set; }
    public override string ContactType => "Family";
    public override string ExtraDetails => $"Relationship: {Relationship}";

    public FamilyContact(string firstName, string lastName, string phone,
        string email, Address address, string relationship)
        : base(firstName, lastName, phone, email, address)
    {
        Relationship = relationship;
    }
}
