using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? first = null;
        double? second = null;
        Console.WriteLine(first + "\n" + second);
        first += 10;
        second += null;
        Console.WriteLine(first + "\n" + second);
    }
}