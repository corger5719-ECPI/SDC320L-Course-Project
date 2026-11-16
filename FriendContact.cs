/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: A friend contact with an additional birthday property.
Demonstrates inheritance from Contact.
*/
namespace RolodexContacts;

// Inheritance: FriendContact IS a Contact.
public class FriendContact : Contact
{
    public string Birthday { get; set; }
    public override string ContactType => "Friend";
    public override string ExtraDetails => $"Birthday: {Birthday}";

    public FriendContact(string firstName, string lastName, string phone,
        string email, Address address, string birthday)
        : base(firstName, lastName, phone, email, address)
    {
        Birthday = birthday;
    }
}
