using System;

class Program
{
    static void Main(string[] args)
    {
        //creating a new instance of the product list
        List<Product> order1Products = new List<Product>();

        //creating the first order
        Product product = new Product("Laptop", "P100", 500, 1);
        order1Products.Add(product);
        
        //creating another instance of the second order
        Product product1 = new Product("Mouse", "P101", 20, 2);
        order1Products.Add(product1);

        //creating an instance of the Address class using its constructor
        Address address1 = new Address("123 Main Street", "Dallas", "Texas", "USA");

        //creating an instance of the customer class using its constructor
        Customer customer1 = new Customer("John Smith", address1);

        //creating an instance of the order class using its constructor
        Order order1 = new Order(order1Products, customer1);

        //------ORDER 2-----------------------------------------------


        List<Product> order2Products = new List<Product>();

        Product product2 = new Product("Phone", "P200", 300, 1);
        order2Products.Add(product2);

        Product product3 = new Product("Charger", "P201", 25, 2);
        order2Products.Add(product3);

        Product product4 = new Product("Earbuds", "P202", 50, 1);
        order2Products.Add(product4);
        
        Address address2 = new Address("15 King Road", "Lagos", "Lagos State","Nigeria");

        Customer customer2 = new Customer("Mary Jones", address2);

        Order order2 = new Order(order2Products, customer2);


        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order1.PackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");

        Console.WriteLine("\n----------------------------\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine("PACKING LABEL");
        Console.WriteLine(order2.PackingLabel());

        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");

    }
}