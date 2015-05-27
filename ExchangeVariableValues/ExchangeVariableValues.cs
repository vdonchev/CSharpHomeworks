using System;

class ExchangeVariableValues
{
    static void Main()
    {
        uint a = 5;
        uint b = 10;
        Console.WriteLine("Before:\n" + a + "\n" + b);
        // method 1 - with third variable
        uint c = a;
        a = b;
        b = c;
        Console.WriteLine("After:\n" + a + "\n" + b);

        a = 5;
        b = 10;
        Console.WriteLine("Before:\n" + a + "\n" + b);
        // method 2 - withoout third variable
        a += b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After:\n" + a + "\n" + b);
    }
}