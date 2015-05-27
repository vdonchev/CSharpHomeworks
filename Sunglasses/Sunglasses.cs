using System;

class Sunglasses
{
    static void Main()
    {
        byte height = byte.Parse(Console.ReadLine());
        for (byte i = 0; i < height; i++)
        {
            if(i == 0 || i == height-1)
            {
                string frame = new string('*', height * 2);
                string bridge = new string(' ', height);
                Console.WriteLine("{0}{1}{0}", frame, bridge);
            }
            else
            {
                string frame = "*";
                string lens = new string('/', height * 2 - 2);
                string bridge = new string(' ', height);
                if (height / 2 == i)
                {
                    bridge = new string('|', height);
                }
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", frame, lens, bridge);
            }
        }
    }
}