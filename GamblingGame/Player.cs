
class Player
{
    public int money = 100;
    protected int debt = 1000000;
    protected int blood = 100;
    public int bloodAmount()
    {
        return blood;
    }

    // This is where i create all the body parts you are able to sell
    public List<BodyPart> Body = new List<BodyPart>();
    public BodyPart RightHand = new BodyPart { name = "Right hand", value = 500, bloodLoss = 10 };
    public BodyPart LeftHand = new BodyPart { name = "Left hand", value = 500, bloodLoss = 10 };
    public BodyPart RightArm = new BodyPart { name = "Right Arm", value = 2000, bloodLoss = 30 };
    public BodyPart LeftArm = new BodyPart { name = "Left Arm", value = 2000, bloodLoss = 30 };
    public BodyPart RightLeg = new BodyPart { name = "Right Leg", value = 4000, bloodLoss = 50 };
    public BodyPart LeftLeg = new BodyPart { name = "Left Leg", value = 4000, bloodLoss = 50 };
    public BodyPart RightFoot = new BodyPart { name = "Right Foot", value = 10000, bloodLoss = 15 };
    public BodyPart leftFoot = new BodyPart { name = "Left Foot", value = 10000, bloodLoss = 15 };
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
            if (amount < 0 || amount > money)
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
        int sellChoice = -1;
        if (Body.Count < 1)
        {
            Console.WriteLine("You dont have any limbs left too sell!");
        }
        else
        {
            Console.WriteLine("Which body part do you want to sell?");
            for (int i = 0; i < Body.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Body[i].name} (Value: {Body[i].value}$, Blood Cost: {Body[i].bloodLoss}%)");
            }
            while (sellChoice < 1 || sellChoice > Body.Count)
            {
                string Choice = Console.ReadLine().ToLower();
                if (int.TryParse(Choice, out sellChoice) || sellChoice > Body.Count)
                {
                    Console.WriteLine("It didnt work!");
                }
            }
            BodyPart selectedPart = Body[sellChoice - 1];
            Body.RemoveAt(sellChoice - 1);
            money += selectedPart.value;
            blood -= selectedPart.bloodLoss;
        }

    }
    public void Beg(People Person)
    {

    }
}
