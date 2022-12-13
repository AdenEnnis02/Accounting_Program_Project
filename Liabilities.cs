namespace Accounting
{
    class Liabilities : Formula
    {
        Dictionary<string, float> currentLiabilities = new Dictionary<string, float>();
        Dictionary<string, float> fixedLiabilities = new Dictionary<string, float>();

        public float totalLiabilities = 0;
        public float totalCurrentLiabilities = 0;
        public float totalFixedLiabilities = 0;


        public float addCurrentliabilities()
        {
            foreach (var liability in currentLiabilities)
            {
                totalCurrentLiabilities += liability.Value;
            }
            return totalCurrentLiabilities;
        }

        public float addFixedliabilities()
        {
            foreach (var liability in fixedLiabilities)
            {
                totalFixedLiabilities += liability.Value;
            }
            return totalFixedLiabilities;
        }
        public float addLiabilities()
        {
            totalLiabilities = totalCurrentLiabilities + totalFixedLiabilities;
            return totalLiabilities;
        }

        public void createDict()
        {
            currentLiabilities.Add("notesPayable1", 0);
            currentLiabilities.Add("accountPayable", 0);
            currentLiabilities.Add("wagesPayable", 0);
            currentLiabilities.Add("interestPayable", 0);
            currentLiabilities.Add("taxesPayable", 0);
            currentLiabilities.Add("warrantyLiability", 0);
            currentLiabilities.Add("unearnedRevenues", 0);
            fixedLiabilities.Add("notePayable2", 0);
            fixedLiabilities.Add("bondsPayable", 0);
        }

        public void updateCurrentLiabilities()
        {
            Console.WriteLine(" Enter your Current Liabilities: ");
            Console.WriteLine("1. Notes Payable: ");
            currentLiabilities["notesPayable1"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("2. Account Payable: ");
            currentLiabilities["accountPayable"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("3. Wages Payable: ");
            currentLiabilities["wagesPayable"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("4. Taxes Payable: ");
            currentLiabilities["taxesPayable"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("5. Warranty Liabilty: ");
            currentLiabilities["warrantyLiability"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("6. Unearned Revenues: ");
            currentLiabilities["unearnedRevenues"] = float.Parse(Console.ReadLine() ?? "");
        }

        public void updateLongTermLiabilities()
        {
            Console.WriteLine(" Enter your Long-Term Liabilities: ");
            Console.WriteLine("1. Notes Payable: ");
            fixedLiabilities["notesPayable2"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("2. Bonds Payable: ");
            fixedLiabilities["notesPayable"] = float.Parse(Console.ReadLine() ?? "");
        }

        public void printLiabilities()
        {
            foreach (var item in currentLiabilities)
            {
                Console.WriteLine(item.Key + ": $" + item.Value);
            }
            foreach (var item in currentLiabilities)
            {
                Console.WriteLine(item.Key + ": $" + item.Value);
            }
        }
        public void createLiabilities()
        {
            createDict();
            updateCurrentLiabilities();
            updateLongTermLiabilities();
        }
        public override void Calculate()
        {
            Console.WriteLine("");
            Console.WriteLine("Your liabilities:");
            addCurrentliabilities();
            addFixedliabilities();
            addLiabilities();
            Console.WriteLine("Total Current Liabilities: $" + this.totalCurrentLiabilities);
            Console.WriteLine("Total Fixed Liabilities: $" + this.totalFixedLiabilities);
            Console.WriteLine("Total Liabilities: $" + this.totalLiabilities);
        }
    }
}