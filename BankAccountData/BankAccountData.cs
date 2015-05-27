using System;

class BankAccountData
{
    static void Main()
    {
        string firstName, middleName, lastName, iban, bankName;
        decimal accountBallance;
        long creditCard1, creditCard2, creditCard3;
        firstName = "Videlin";
        middleName = "Zlatev";
        lastName = "Donchev";
        accountBallance = 159256.25M;
        iban = "BG43STSA93000009998877";
        bankName = "DSK Bank";
        creditCard1 = 4053036719447148;
        creditCard2 = 4929851421849429;
        creditCard3 = 4868603234705691;
        Console.WriteLine("Full name: " + firstName + " " + middleName + " " + lastName);
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("IBAN: " + iban);
        Console.WriteLine("Current ballance: " + accountBallance);
        Console.WriteLine("Credit card Numbers: " + creditCard1 + ", " + creditCard2 + ", " + creditCard3);
    }
}