class Equity
{
    Dictionary<string, int> equity = new Dictionary<string, int>();
    
    public int totalEquity = 0;

    public float addliabilities()
{
    foreach(var n in equity){
        totalEquity += n.Value;
    }
    return totalEquity;
}

public void createDict()
{
    equity.Add("cash", 0);
    equity.Add("pettyCash", 0);
    equity.Add("inventory", 0);
    equity.Add("supplies", 0);
    equity.Add("tempInvestments", 0);
    equity.Add("accountReceivable", 0);

}

public void updateDict()
{
    Console.WriteLine(" Enter your liabilities: ");
    Console.WriteLine("1. Cash: ");
    equity["cash"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("2. Petty Cash: ");
    equity["pettyCash"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("3. Inventory: ");
    equity["inventory"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("4. Supplies: ");
    equity["supplies"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("5. Temporary Investments: ");
    equity["tempInvestments"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("6. Account Receivables: ");
    equity["accountReceivables"] = Int32.Parse(Console.ReadLine()??"");
}

}

