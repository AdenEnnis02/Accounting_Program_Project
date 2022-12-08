class Assets
{
    Dictionary<string, int> assets = new Dictionary<string, int>();
    
    public int totalAssets = 0;

    public float addAssets()
{
    foreach(var asset in assets){
        totalAssets += asset.Value;
    }
    return totalAssets;
}

public void createDict()
{
    assets.Add("cash", 0);
    assets.Add("pettyCash", 0);
    assets.Add("inventory", 0);
    assets.Add("supplies", 0);
    assets.Add("tempInvestments", 0);
    assets.Add("accountReceivable", 0);
    assets.Add("land", 0);
    assets.Add("landImprovemnets", 0);
    assets.Add("buildings", 0);
    assets.Add("equipment", 0);
}

public void updateCurrentAssets()
{
    Console.WriteLine(" Enter your Current Assets: ");
    Console.WriteLine("1. Cash: ");
    assets["cash"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("2. Petty Cash: ");
    assets["pettyCash"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("3. Inventory: ");
    assets["inventory"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("4. Supplies: ");
    assets["supplies"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("5. Temporary Investments: ");
    assets["tempInvestments"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("6. Account Receivables: ");
    assets["accountReceivables"] = Int32.Parse(Console.ReadLine()??"");
}
public void updateFixedAssets()
{
    Console.WriteLine(" Enter your Fixed Assets: ");
    Console.WriteLine("1. Land: ");
    assets["land"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("2. Land Improvements: ");
    assets["landImprovements"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("3. Buildings: ");
    assets["buildings"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("4. Equipment: ");
    assets["equipment"] = Int32.Parse(Console.ReadLine()??"");
} 
}

