/*I don't think there is any exceeding/comment that needs to be made, but just in case, I didn't really do any excess creativity except for the details on orders/addresses!
~ Thanks! ~*/ 

using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Lincoln", "NE", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A101", 800, 1));
        order1.AddProduct(new Product("Mouse", "B202", 25, 2));


        Address address2 = new Address("456 King Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "C303", 600, 1));
        order2.AddProduct(new Product("Headphones", "D404", 50, 3));
        order2.AddProduct(new Product("Charger", "E505", 20, 2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}