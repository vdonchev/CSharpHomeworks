using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;
        double a = 0.0000007;
        double b = 0.00000007;
        double diff = Math.Abs(a - b);
        if (diff < eps)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}