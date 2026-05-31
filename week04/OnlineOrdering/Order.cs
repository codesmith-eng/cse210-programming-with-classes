using System;
using System.Collections.Generic;
using System.Net.Sockets;

public class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;


    //constructor for Order
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    //Adding shipping cost to Total cost
    //if customer is in USA add $5 if not add $35
    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.totalCost();
        }

        if (_customer.LivesInUsa() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    //packing label returning the product name and id
    public string PackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"Name: {product.GetName()} ID: {product.GetId()}";
        }
        return label.ToString();
    }

    //packing label returning the customer name and address
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()} {_customer.GetAddress().TheAddress()}";
    }

}




