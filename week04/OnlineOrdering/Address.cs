// this class for customer name, adress, city, state, country

using System;
public class Address
{
    // private variabls : The address contains a string for the street address, the city, state/province, and country.
    private string _streetAddress;  // adress
    private string _city;   // city
    private string _stateOrProvince;   //state
    private string _country;  //country

// Constructor : to remove the before created it
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateOrProvince = state;
        _country = country;
    }    
    // The address should have a method that can return whether it is in the USA or not.
    public bool IsInUSA() // bool = true or false with use "is" like as question 
    { 
        // country name untid state or letters usa lower letter
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        //The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    public string GetFullAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}           

