using System;

class Program
{
    static void Main(string[] args)
    {
        // prepare first order : inside usa 
        Address address1 = new Address("123 Abd-Elhameed St", "New-Yourk", "ID", "USA");
        Customer customer1 = new Customer("Brother Kevin Barker", address1);
        Order order1 = new Order(customer1);

        // product (name, code, price, quntitiy)
        Product p1 = new Product("Phone", "A123", 15.50, 2);
        Product p2 = new Product("Laptop", "B456", 45.00, 1);
        Product p3 = new Product("Power bank", "C789", 8.99, 3);

       
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);

        // prepare second order : outside USA
        Address address2 = new Address("45 El-Tahrir St", "Cairo", "Cairo Governorate", "Egypt");
        Customer customer2 = new Customer("Emad Fawzy", address2);
        Order order2 = new Order(customer2);
        
        Product p4 = new Product("pc desktop", "L990", 1200.00, 1);
        Product p5 = new Product("Keybaord", "S105", 25.00, 1);

        order2.AddProduct(p4);
        order2.AddProduct(p5);

        // Displaying and abstracting the first order
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("                  First Order                     ");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost (with $5 USA shipping): ${order1.CalculateTotalOrderCost():F2}");
        Console.WriteLine();

        // Displaying and abstracting the second order
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("                  Second Order                    ");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost (with $35 Intl shipping): ${order2.CalculateTotalOrderCost():F2}");
        Console.WriteLine("---------------------------------------------------");
    }
}
