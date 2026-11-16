
class Player
{
    protected int money = 100;
    protected int debt = 1000000;
    protected float blood = 100;
    protected float minimumBlood = 50;
    
    public void Stats()
    {
        Console.WriteLine($"Cash: {money}$");
        Console.WriteLine($"Debt: {debt}$");
        Console.WriteLine($"blood left: {blood}%");
    }
    public void PayDebt()
    {
        int amount = 0;
        Console.WriteLine("How much do you want to pay of?");

        while (amount <= 0 || amount > money)
        {
            string payChoice = Console.ReadLine();
            payChoice = payChoice.ToLower();
            bool I;
            I = int.TryParse(payChoice, out amount);
            if(amount <= 0 || amount > money)
            {
                Console.WriteLine("I didnt work!");
            }
        }
        money -= amount;
        debt -= amount;
        Console.WriteLine(debt);
        
    }
    public void SellBody(BodyPart part)
    {
        money += part.value;

    }
    public void Beg(People Person)
    {
        
    }
}