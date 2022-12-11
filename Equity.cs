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
    equity.Add("commonStock", 0);
    equity.Add("retainedEarnings", 0);
    equity.Add("treasuryStock", 0);
}

public void updateEquity()
{
    Console.WriteLine(" Enter your Equities: ");
    Console.WriteLine("1. Common Stock: ");
    equity["commonStock"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("2. Retained Earnings: ");
    equity["retainedEarnings"] = Int32.Parse(Console.ReadLine()??"");
    Console.WriteLine("3. Treasury Stock: ");
    equity["treasuryStock"] = Int32.Parse(Console.ReadLine()??"");
}

}

