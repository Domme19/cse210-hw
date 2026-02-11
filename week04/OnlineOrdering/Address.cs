using System.ComponentModel;
using System.Linq.Expressions;

class Address
{
    private int _streetNo;
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;


    public Address(int streetNo, string streetName, string city, string state, string country)
    {
        _streetNo = streetNo;
        _streetName = streetName;
        _city = city;
        _state = state;
        _country = country;
    }


    // public int GetStreetNo()
    // {
    //     return _streetNo;
    // }



    // public string GetStreetName()
    // {
    //     return _streetName;
    // }



    // public string GetCity()
    // {
    //     return _city;
    // }



    // public string GetState()
    // {
    //     return _state;
    // }


    // public string GetCountry()
    // {
    //     return _country;
    // }

    public bool IsAddressInUsa()
    {
        string trimmedCountryField = _country.Trim().ToLower(); 
        return trimmedCountryField == "usa" || trimmedCountryField == "us"; 

    }
    public string FullAddress()
    {
        return $"{_streetNo} {_streetName}, {_city}, {_state}, {_country}"; 
    }




}