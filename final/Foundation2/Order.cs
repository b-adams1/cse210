using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetTotalCost();
        }

        if (customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string result = "Packing Label:\n";

        foreach (Product p in products)
        {
            result += p.GetName() + " (ID: " + p.GetProductId() + ")\n";
        }

        return result;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetName() + "\n" + customer.GetAddress();
    }
}