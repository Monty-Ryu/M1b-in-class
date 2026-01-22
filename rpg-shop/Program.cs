//Step 1. ask player name (and remember it)
Console.WriteLine("What is your name, champion?");
string playerName = Console.ReadLine();

//Step 2. Ask player for sum of held gold(currency)
Console.WriteLine("How much gold do you have on you, champion?");
string heldGold = Console.ReadLine();

//Step 3. Tell player that a bronze sword costs 15 gold and if they wish to buy
Console.WriteLine("Do you want to buy a bronze sword I have, champion?");
Console.WriteLine("Do you wish to buy it for 15 gold?");
string doPurchaseSword = Console.ReadLine();
if (doPurchaseSword == "yes")
{
    //3a buy sword
    if (/* has enough gold */)
    {

    }
}
else
{
    Console.WriteLine($"Farewell on your travels, {playerName}");
}