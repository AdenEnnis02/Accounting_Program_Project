class AccountingFormula: Formula
{
    public bool balanced = true;
    Assets asset = new Assets();
    public override void Calculate()
    {
        if (asset.totalAssets != (totalLiabilities + totalEquity))
        {
            balanced = false;
        }
        else if (totalEquity != (asset.totalAssets - totalLiabilities))
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
