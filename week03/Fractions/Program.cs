using System;

class Program
{
    static void Main(string[] args)
    {
        // try first constructor as default 
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());  // should print 1/1
        Console.WriteLine(f1.GetDecimalValue());  // should print 1
    
        // try second contructor only one number
        Fraction f2 = new Fraction (5);
        Console.WriteLine(f2.GetFractionString());  // should print 5/1
        Console.WriteLine(f2.GetDecimalValue());  // should print 5

        // try third contructor 
        Fraction f3 = new Fraction (3, 4);
        Console.WriteLine(f3.GetFractionString());  // should print 3/4
        Console.WriteLine(f3.GetDecimalValue());  // should print 0.75
        
        // try another one
        Fraction f4 = new Fraction (1, 3);
        Console.WriteLine(f4.GetFractionString());  // should print 1/3
        Console.WriteLine(f4.GetDecimalValue());  // should print 0.3333

    }
        
} // it works well
