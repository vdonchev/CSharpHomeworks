using System;

class QuotesInStrings
{
    static void Main()
    {
        string first = "The \"use\" of quotations causes difficulties.";
        string second = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(first + "\n" + second);

        string check = (first == second) ? "Both stringss looks identical" : "There are differences";
        Console.WriteLine(check);
    }
}