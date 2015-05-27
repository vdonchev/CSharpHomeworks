using System;

class ASCIITablePrinter
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        byte col = 1;
        for (ushort i = 0; i <= 255; i++)
        {
            if(col < 10)
            {
                if (!char.IsControl((char)i))
                {
                    Console.Write(i + "[" + (char)i + "]\t");
                    col++;
                }
            }
            else
            {
                if (!char.IsControl((char)i))
                {
                    Console.Write(i + "[" + (char)i + "]");
                    Console.WriteLine();
                    col = 1;
                }
            }
        }
        Console.WriteLine();
    }
}