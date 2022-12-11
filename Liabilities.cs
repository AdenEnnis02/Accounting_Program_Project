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
        liabilities.Add("notesPayable1", 0);
        liabilities.Add("accountPayable", 0);
        liabilities.Add("wagesPayable", 0);
        liabilities.Add("interestPayable", 0);
        liabilities.Add("taxesPayable", 0);
        liabilities.Add("warrantyLiability", 0);
        liabilities.Add("unearnedRevenues", 0);
        liabilities.Add("notePayable2", 0);
        liabilities.Add("bondsPayable", 0);



    }

    public void updateCurrentLiabilities()
    {
        Console.WriteLine(" Enter your Current Liabilities: ");
        Console.WriteLine("1. Notes Payable: ");
        liabilities["notesPayable1"] = Int32.Parse(Console.ReadLine()??"");
        Console.WriteLine("2. Account Payable: ");
        liabilities["accountPayable"] = Int32.Parse(Console.ReadLine()??"");
        Console.WriteLine("3. Wages Payable: ");
        liabilities["wagesPayable"] = Int32.Parse(Console.ReadLine()??"");
        Console.WriteLine("4. Taxes Payable: ");
        liabilities["taxesPayable"] = Int32.Parse(Console.ReadLine()??"");
        Console.WriteLine("5. Warranty Liabilty: ");
        liabilities["warrantyLiability"] = Int32.Parse(Console.ReadLine()??"");
        Console.WriteLine("6. Unearned Revenues: ");
        liabilities["unearnedRevenues"] = Int32.Parse(Console.ReadLine()??"");
    }

    public void updateLongTermLiabilities()
    {
        Console.WriteLine(" Enter your Long-Term Liabilities: ");
        Console.WriteLine("1. Notes Payable: ");
        liabilities["notesPayable2"] = Int32.Parse(Console.ReadLine()??"");
        Console.WriteLine("2. Bonds Payable: ");
        liabilities["notesPayable"] = Int32.Parse(Console.ReadLine()??"");
    }
}

