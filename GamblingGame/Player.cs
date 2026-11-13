
class Player
{
    protected int money = 100;
    protected int debt = 1000000;
    protected float blood = 100;
    protected float minimumBlood = 50;
    

    public void PayDebt()
    {
        string payChoice;
        int Amount = 0;
        Console.WriteLine("How much do you want to pay of?");

        while (Amount > 0)
        {
            payChoice = Console.ReadLine();
            payChoice = payChoice.ToLower();
            bool I;
            I = int.TryParse(payChoice, out Amount);
        }
        
        
        
    }
    public void SellBody(BodyPart part)
    {
        money += part.value;

    }
}