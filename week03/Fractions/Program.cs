using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString());
    
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString());
    
        Console.WriteLine(frac3.GetTop());
        Console.WriteLine(frac3.GetBottom());
        
        frac3.SetTop(7);
        frac3.SetBottom(2);
        Console.WriteLine(frac3.GetFractionString());
        
        Console.WriteLine(frac3.GetDecimalValue());
    }
}