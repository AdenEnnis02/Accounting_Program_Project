class AccountingFormula: Formula
{
    public bool balanced = true;
    Assets asset = new Assets();
<<<<<<< Updated upstream
    public override void Calculate()
=======
    Liabilities liability = new Liabilities();
    Equity equity = new Equity();
    public void balanceCheck()
>>>>>>> Stashed changes
    {
        if (asset.totalAssets != (liability.totalLiabilities + equity.totalEquity))
        {
            balanced = false;
        }
        else if (equity.totalEquity != (asset.totalAssets - liability.totalLiabilities))
        {
            balanced = false;
        }
        else if (netIncome != (revenue - expenses))
        {
            balanced = false;
        }

    }
}

class LiquidityRatios: Formula
{
    public override void Calculate()
    {
        currentRatio = totalCurrentAssets / totalCurrentLiabilities
        quickRatio = totalMoneyAssests / totalCurrentLiabilities
    }
}

class SolvencyRatios: Formula
{
    public override void Calculate()
    {
        debtToEquity = totalLiabilities / totalEquity
    }
}

class ProfitabilityRatios: Formula
{
    public override void Calculate()
    {
        grossMargin = grossProfit / Sales
        int grossProfit = sales - costOfGoodsSold
        profitMargin = netIncome / Sales
    }
}
