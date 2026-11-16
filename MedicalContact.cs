/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: A medical contact with an additional specialty property.
Demonstrates inheritance from Contact.
*/
namespace RolodexContacts;

// Inheritance: MedicalContact IS a Contact.
public class MedicalContact : Contact
{
    public string Specialty { get; set; }
    public override string ContactType => "Medical";
    public override string ExtraDetails => $"Specialty: {Specialty}";

    public MedicalContact(string firstName, string lastName, string phone,
        string email, Address address, string specialty)
        : base(firstName, lastName, phone, email, address)
    {
        Specialty = specialty;
    }
}
