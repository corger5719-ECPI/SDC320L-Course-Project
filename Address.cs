/*
Cora Germany
November 15, 2026
SDC320 - Course Project Week 1: Rolodex Contacts Application
Purpose: Represents the mailing address that belongs to a contact.
This class is a component of Contact (composition).
*/
namespace RolodexContacts;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }

    public Address(string street, string city, string state, string zipCode)
    {
        Street = street;
        City = city;
        State = state;
        ZipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {ZipCode}";
    }
}
