/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: Base class holding details shared by all contact types.
Its Address property demonstrates composition (a Contact HAS an Address).
*/
namespace RolodexContacts;

public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Address MailingAddress { get; set; }

    public virtual string ContactType => "General";
    public virtual string ExtraDetails => "";

    public Contact(string firstName, string lastName, string phone,
        string email, Address mailingAddress)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Email = email;
        // Composition: a Contact stores an Address object.
        MailingAddress = mailingAddress;
    }

    public override string ToString()
    {
        return $"Type: {ContactType}\nName: {LastName}, {FirstName}" +
               $"\nPhone: {Phone}\nEmail: {Email}" +
               $"\nAddress: {MailingAddress}" +
               (string.IsNullOrWhiteSpace(ExtraDetails) ? "" : $"\n{ExtraDetails}");
    }
}
