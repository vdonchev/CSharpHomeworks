using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leapYear = Console.ReadLine();
        ushort hollydays = ushort.Parse(Console.ReadLine());
        byte hometownVisits = byte.Parse(Console.ReadLine());

        byte weeks = 52;
        weeks -= hometownVisits;
        double totalPlays = (weeks * 2 / 3) + hometownVisits + (hollydays / 2);
        totalPlays = (leapYear == "t") ? totalPlays + 3 : totalPlays;

        Console.WriteLine((int)totalPlays);
    }
}