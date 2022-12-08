class AccountingFormula
{
    public bool balanced = true;
    Assets asset = new Assets();
    public void balanceCheck()
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
