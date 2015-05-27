using System;

class StringsAndObjects
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object firstSecond = first + " " + second;
        string third = (string)firstSecond;
        Console.WriteLine(third);
    }
}