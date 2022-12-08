class Ratios
{
    public float numerator;
    public float denominator;
}
class LiquidityRatio: Ratios
{
    public float CurrentRatio(int numerator, int denominator)
    {
        var currentRatio = (numerator / denominator);
        return currentRatio;
    }
    public float QuickRatio(int numerator, int denominator)
    {
        var Ratio = (numerator / denominator);
        return currentRatio;
    }

}