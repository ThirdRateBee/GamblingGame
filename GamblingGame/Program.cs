using System;
using System.Security.Cryptography.X509Certificates;

Player test = new();

bool Love = true;

test.Stats();
while (Love)
{
    if (Console.KeyAvailable)
    {
        string input = Console.ReadLine().ToLower();

        if (input == "pay")
        {
            test.PayDebt();
        }
        else if (input == "i")
        {
            test.Stats();
        }
        else if (input == "sell")
        {
            test.SellBody();
            test.Stats();
        }
        else if (input == "x")
        {
            Love = false;
        }
    }
    Thread.Sleep(100);
}

Console.ReadLine();


