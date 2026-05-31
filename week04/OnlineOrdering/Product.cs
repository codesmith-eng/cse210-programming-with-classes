using System;

public class Product
{

    private string _name;
    private string _id;
    private double _price;
    private double _quantity;


    //--------constructor for products
    public Product(string name, string id, double price, double quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    //returning the value of _name member variable to the PackingLabel() in order class
    public string GetName()
    {
        return _name;
    }

    //returning the value of _id member variable to the Order class
    public string GetId()
    {
        return _id;
    }

    //calculating the total cost and returning it to the order class for final calculation
    public double totalCost()
    {
        double costAll = _price * _quantity;
        return costAll;
    }


}

