//Step 1. ask player name (and remember it)
using System.ComponentModel.Design;

Console.WriteLine("What is your name, champion?");
string playerName = Console.ReadLine();

//Step 2. Ask player for sum of held gold(currency)
Console.WriteLine("How much gold do you have on you, champion?");
//string heldGoldText = Console.ReadLine();
//int heldGold = int.Parse(heldGoldText);
int heldGold = int.Parse(Console.ReadLine());

//Step 3. Tell player that a bronze sword costs 15 gold and if they wish to buy
Console.WriteLine("Do you want to buy a bronze sword I have, champion?");
Console.WriteLine("Do you wish to buy it for 15 gold?");
string doPurchaseSword = Console.ReadLine();
if (doPurchaseSword == "yes")
{
    //3a buy sword
    if (heldGold >= 15)
    {
        //Deduct cost
        heldGold -= 15;
        //heldGold = heldGold - 15;

        //Inform player of remaining gold
        Console.WriteLine($"You have {heldGold} gold remaining.");
    }
    else
    { //Not enough gold
        Console.WriteLine($"{playerName}, you only have{heldGold} left.");
        Console.WriteLine($"You cannot afford the bronze sword.");
    }
}
