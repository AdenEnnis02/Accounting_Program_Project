class Liabilities
{
    Dictionary<string, int> liabilities = new Dictionary<string, int>();
    
    public int totalLiabilities = 0;

    public float addliabilities()
{
    foreach(var liability in liabilities){
        totalLiabilities += liability.Value;
    }
    return totalLiabilities;
}

public void createDict()
{
    liabilities.Add("cash", 0);
    liabilities.Add("pettyCash", 0);
    liabilities.Add("inventory", 0);
    liabilities.Add("supplies", 0);
    liabilities.Add("tempInvestments", 0);
    liabilities.Add("accountReceivable", 0);

}

public void updateDict()
{
    Console.WriteLine(" Enter your liabilities: ");
    Console.WriteLine("1. Cash: ");
    liabilities["cash"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("2. Petty Cash: ");
    liabilities["pettyCash"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("3. Inventory: ");
    liabilities["inventory"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("4. Supplies: ");
    liabilities["supplies"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("5. Temporary Investments: ");
    liabilities["tempInvestments"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("6. Account Receivables: ");
    liabilities["accountReceivables"] = Int32.Parse(Console.ReadLine()??"");
}

}

