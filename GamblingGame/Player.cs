
class Player
{
    public int money = 100;
    protected int debt = 1000000;
    protected float blood = 100;
    protected float minimumBlood = 0;
    
    // This is where i create all the body parts you are able to sell
    public List<BodyPart> Body = new List<BodyPart>();
    public BodyPart RightHand = new BodyPart {value = 500, bloodLoss = 10};
    public BodyPart LeftHand = new BodyPart {value = 500, bloodLoss = 10};
    public BodyPart RightArm = new BodyPart {value = 2000, bloodLoss = 30};
    public BodyPart LeftArm = new BodyPart {value = 2000, bloodLoss = 30};
    public BodyPart RightLeg = new BodyPart {value = 4000, bloodLoss = 50};
    public BodyPart LeftLeg = new BodyPart {value = 4000, bloodLoss = 50};
    public BodyPart RightFoot = new BodyPart {value = 10000, bloodLoss = 15};
    public BodyPart leftFoot = new BodyPart {value = 10000, bloodLoss = 15};
    public Player()
    {
        // This is where I add the body parts to the player
        Body.Add(RightHand);
        Body.Add(LeftHand);
        Body.Add(RightArm);
        Body.Add(LeftArm);
        Body.Add(RightLeg);
        Body.Add(LeftLeg);
        Body.Add(RightFoot);
        Body.Add(leftFoot);
    }
    public void Stats()
    {
        Console.WriteLine($"Cash: {money}$");
        Console.WriteLine($"Debt: {debt}$");
        Console.WriteLine($"blood left: {blood}%");
    }
    public void PayDebt() //Pays of the debt the player has based on the amount of money they choose to pay with.
    {
        int amount = -1;
        Console.WriteLine("How much do you want to pay of?");

        while (amount < 0 || amount > money)
        {
            string payChoice = Console.ReadLine().ToLower();
            bool I;
            I = int.TryParse(payChoice, out amount);
            if(amount < 0 || amount > money)
            {
                Console.WriteLine("I didnt work!");
            }
        }
        money -= amount;
        debt -= amount;
        Console.WriteLine(debt);
        
    }
    public void SellBody()
    {
        money += 0;
    }
    public void Beg(People Person)
    {
        
    }
}
