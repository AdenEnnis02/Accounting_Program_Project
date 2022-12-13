namespace Accounting
{
    class Assets: Formula
    {
        public float totalCurrentAssets = 0;
        public float totalFixedAssets = 0;
        public float totalAssets = 0;
        public Dictionary<string, float> current = new Dictionary<string, float>();
        public Dictionary<string, float> fixedasset = new Dictionary<string, float>();
        

        public float addCurrentAssets()
        {
            foreach (var asset in current)
            {
                totalCurrentAssets += asset.Value;
            }
            return totalCurrentAssets;
        }
        public float addfixedAssets()
        {
            foreach (var asset in fixedasset)
            {
                totalFixedAssets += asset.Value;
            }
            return totalFixedAssets;
        }
        public float addAssets()
        {
            totalAssets = totalCurrentAssets + totalFixedAssets;
            return totalAssets;
        }

        // public void createAssetsDict()
        // {
        //     assets.Add("cash", 0);
        //     assets.Add("pettyCash", 0);
        //     assets.Add("inventory", 0);
        //     assets.Add("supplies", 0);
        //     assets.Add("tempInvestments", 0);
        //     assets.Add("accountReceivable", 0);
        //     assets.Add("land", 0);
        //     assets.Add("landImprovements", 0);
        //     assets.Add("buildings", 0);
        //     assets.Add("equipment", 0);
        // }
        public void createCurrentAssetsDict()
        {
            current.Add("cash", 0);
            current.Add("pettyCash", 0);
            current.Add("inventory", 0);
            current.Add("supplies", 0);
            current.Add("tempInvestments", 0);
            current.Add("accountReceivable", 0);
        }
         public void createFixedAssetsDict()
        {
            fixedasset.Add("land", 0);
            fixedasset.Add("landImprovements", 0);
            fixedasset.Add("buildings", 0);
            fixedasset.Add("equipment", 0);
        }

        public void updateCurrentAssets()
        {
            Console.WriteLine(" Enter your Current Assets: ");
            Console.WriteLine("1. Cash: ");
            current["cash"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("2. Petty Cash: ");
            current["pettyCash"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("3. Inventory: ");
            current["inventory"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("4. Supplies: ");
            current["supplies"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("5. Temporary Investments: ");
            current["tempInvestments"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("6. Account Receivables: ");
            current["accountReceivable"] = float.Parse(Console.ReadLine() ?? "");
        }
        public void updateFixedAssets()
        {
            Console.WriteLine(" Enter your Fixed Assets: ");
            Console.WriteLine("1. Land: ");
            fixedasset["land"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("2. Land Improvements: ");
            fixedasset["landImprovements"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("3. Buildings: ");
            fixedasset["buildings"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("4. Equipment: ");
            fixedasset["equipment"] = float.Parse(Console.ReadLine() ?? "");
        }

        public void printAssets()
        {
            foreach (var item in current)
            {
                Console.WriteLine(item.Key + ": $" + item.Value);
            }
            foreach (var item in fixedasset)
            {
                Console.WriteLine(item.Key + ": $" + item.Value);
            }
        }
        public void createAssets()
        {
                updateCurrentAssets();
                updateFixedAssets();
        }
        public override void Calculate()
        {   
            Console.WriteLine("");
            Console.WriteLine("Your assets:");
            addCurrentAssets();
            addfixedAssets();
            addAssets();
            Console.WriteLine("Total Current Assets: $" + this.totalCurrentAssets);
            Console.WriteLine("Total Fixed Assets: $" + this.totalFixedAssets);
            Console.WriteLine("Total Assets: $" + this.totalAssets);
        }
    }
}
