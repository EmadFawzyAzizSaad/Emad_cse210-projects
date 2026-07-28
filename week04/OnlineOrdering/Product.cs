// Contains the name, product id, price, and quantity of each product.

using System;

public class Product
{
    // private varaibls
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    //The total cost of this product is computed by multiplying the price per unit and the quantity. 
    // (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
        public double CalculateTotalProductPrice()
    {
        return _price * _quantity;
    }
        public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
    
}