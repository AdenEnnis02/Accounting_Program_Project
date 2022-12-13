namespace Accounting
{
    class LiquidityRatios : Formula
    {
        static Assets assets = new Assets();
        static Liabilities liabilities = new Liabilities();
        public float currentRatio = 0;
        public float quickRatio = 0;
        public override void Calculate()
        {
            currentRatio = assets.totalAssets / liabilities.totalCurrentLiabilities;
            quickRatio = assets.totalCurrentAssets / liabilities.totalCurrentLiabilities;
            Console.WriteLine("Your current ratio is:" + currentRatio);
            Console.WriteLine("Your quick ratio is:" + quickRatio);
        }
    }

    class SolvencyRatios : Formula
    {
        public float debtToEquity = 0;
        Liabilities liabilities = new Liabilities();
        static Equity equity = new Equity();

        public override void Calculate()
        {
            this.debtToEquity = liabilities.totalLiabilities / equity.totalEquity;
            Console.WriteLine("Your debt to equity is:" + this.debtToEquity);

        }
    }

    class ProfitabilityRatios : Formula

    {
        public float grossMargin = 0;
        public float grossProfit = 0;
        public float sales = 0;
        public float costOfGoodsSold = 0;
        public void gatherSales()
        {
            Console.WriteLine(" Enter your total sales dollars: ");
            Console.WriteLine("1. Sales: ");
            sales = float.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("");
            Console.WriteLine(" Enter your total sales dollars: ");
            Console.WriteLine("2. Cost of goods sold: ");
            costOfGoodsSold = float.Parse(Console.ReadLine() ?? "");
        }
        public override void Calculate()
        {
            gatherSales();
            this.grossProfit = sales - costOfGoodsSold;
            this.grossMargin = (grossProfit / sales) * 100;
            Console.WriteLine("Your gross profit is: $" + grossProfit );
            Console.WriteLine("Your gross margin is:" + grossMargin +"%");
            
        }
    }
}