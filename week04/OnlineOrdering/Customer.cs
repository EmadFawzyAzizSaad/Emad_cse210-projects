// The customer contains a name and an address.
using System;

public class Customer
{
    private string _name;
    private Address _address;
    // The name is a string, but the Address is a class.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    // The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
    public bool IsFromUSA()
    {
        return _address.IsInUSA();
    }
    public string GetName()
    {
        return _name;
    }
     public Address GetAddress()
    {
        return _address;
    }













}



