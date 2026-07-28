// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.

using System;
using System.Collections.Generic; // to work the list

public class Order
{
// private variabls
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor:
    public Order(Customer customer)
    {
        _customer = customer;
    }
    // to add a new product inside the list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    //The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
    //This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. 
    // If the customer does not live in the USA, then the shipping cost is $35.
    public double CalculateTotalOrderCost()
    {
        double total = 0;
                foreach (Product product in _products)
        {
            total += product.CalculateTotalProductPrice();
        }
    if (_customer.IsFromUSA())
        {
            total += 5; 
        }
        else
        {
            total += 35; 
        }

        return total;
    }
// A packing label should list the name and product id of each product in the order.
    public string GetPackingLabel()
    {
        string label = "--- Packing Label (Items) ---\n"; 
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    //A shipping label should list the name and address of the customer

    public string GetShippingLabel()
    {
        string label = "--- Shipping Label (Address) ---\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddressString() + "\n";
        return label;
    }

}
