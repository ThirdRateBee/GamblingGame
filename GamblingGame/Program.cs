using System;

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
        
        }
        else if (input == "x")
        {
            Love = false;
        }
    }
    Thread.Sleep(100);
}

Console.ReadLine();

void PlayerActions()
{
    
}
