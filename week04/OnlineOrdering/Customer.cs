using System;

//This class handles the customer name and address details
public class Customer
{
    //creating an instance of the address class
    private Address _address;
    private string _name;


    //------constructor to access the private member variables
    //passing the adddress instance to the customer constructor
    public Customer(string name,  Address address)
    {
        _name = name;
        _address = address;
    }

    //returning the value of the GetName() to the GetShippingLabel() in the Order class
    public string GetName()
    {
        return _name;
    }

    //returning the value of the GetAddress() to the GetShippingLabel() in the Order class
    public Address GetAddress()
    {
        return _address;
    }

    //checking if country is USA or not and returning it
    public bool LivesInUsa()
    {
        //calling country method in the address class to receive its return value
        return _address.country();
    }
    
}