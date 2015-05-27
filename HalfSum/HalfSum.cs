using System;

class HalfSum
{
    static void Main()
    {
        ushort sequences = ushort.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < sequences; i++)
        {
            sum1 += int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < sequences; i++)
        {
            sum2 += int.Parse(Console.ReadLine());
        }
        if (sum1 == sum2)
        {
            Console.WriteLine("Yes, sum=" + sum1);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(sum1 - sum2));
        }
    }
}