namespace Accounting
{
    class Equity : Formula
    {
        Dictionary<string, float> equity = new Dictionary<string, float>();

        public float totalEquity = 0;

        public float addEquity()
        {
            foreach (var i in equity)
            {
                totalEquity += i.Value;
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
            equity["commonStock"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("2. Retained Earnings: ");
            equity["retainedEarnings"] = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("3. Treasury Stock: ");
            equity["treasuryStock"] = float.Parse(Console.ReadLine() ?? "");
        }

        public void printEquities()
        {
            foreach (var item in equity)
            {
                Console.WriteLine(item.Key + ": $" + item.Value);
            }
        }

        public void createEquity()
        {
            createDict();
            updateEquity();
        }
        public override void Calculate()
        {   
            Console.WriteLine("");
            Console.WriteLine("Your equity:");
            addEquity();
            Console.WriteLine("Total Equity: $" + this.totalEquity);

        }
    }
}
