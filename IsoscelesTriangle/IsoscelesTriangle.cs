using System;

class IsoscelesTriangle
{
    static void Main()
    {
        char copyRight = '\u00A9';
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0}{0,2}{0,2}{0,2}", copyRight);
    }
}