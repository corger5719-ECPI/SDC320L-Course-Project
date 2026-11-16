/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: A business contact with an additional company property.
Demonstrates inheritance from Contact.
*/
namespace RolodexContacts;

// Inheritance: BusinessContact IS a Contact.
public class BusinessContact : Contact
{
    public string Company { get; set; }
    public override string ContactType => "Business";
    public override string ExtraDetails => $"Company: {Company}";

    public BusinessContact(string firstName, string lastName, string phone,
        string email, Address address, string company)
        : base(firstName, lastName, phone, email, address)
    {
        Company = company;
    }
}
