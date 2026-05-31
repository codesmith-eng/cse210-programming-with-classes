using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //check if country is from USA and return the value to customer class
    // the || is an or statement in c#
    public bool country()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //return the values of the address to the GetShippingLabel() in Order class
    public string TheAddress()
    {
        return _street + " " + _city + " " + _state + " " + _country;
    }
}