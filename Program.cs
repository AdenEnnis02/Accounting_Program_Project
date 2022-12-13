namespace Accounting
{
    class Program
    {
        static Assets assets = new Assets();
        static Liabilities liabilities = new Liabilities();
        static Equity equity = new Equity();
        static LiquidityRatios liquid = new LiquidityRatios();
        static SolvencyRatios solvency = new SolvencyRatios();
        static ProfitabilityRatios profit = new ProfitabilityRatios();

        public static void Main()
        {
                assets.createAssets();
                assets.printAssets();
                assets.Calculate();
                Console.WriteLine("");
                liabilities.createLiabilities();
                liabilities.printLiabilities();
                liabilities.Calculate();
                Console.WriteLine("");
                equity.createEquity();
                equity.printEquities();
                equity.Calculate();
                Console.WriteLine("");
                liquid.currentRatio = assets.totalAssets / liabilities.totalCurrentLiabilities;
                liquid.quickRatio = assets.totalCurrentAssets / liabilities.totalCurrentLiabilities;
                Console.WriteLine("Your current ratio is:" + liquid.currentRatio);
                Console.WriteLine("Your quick ratio is:" + liquid.quickRatio);
                Console.WriteLine("");
                solvency.debtToEquity = liabilities.totalLiabilities / equity.totalEquity;
                Console.WriteLine("Your debt to equity is:" + solvency.debtToEquity);
                Console.WriteLine("");
                profit.Calculate();
        }
    }
}