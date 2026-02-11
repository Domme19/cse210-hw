using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

class Customer
{
    // attributes
    private string _firstName;
    private string _lastName;
    private Address _address;


    public Customer(string firstName, string lastName, Address address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
    }


    public string GetFirstName()
    {
        return _firstName;
    }


    public string GetLastName()
    {
        return _lastName;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetFullAddress()
    {
        return _address.FullAddress(); 
    }

}