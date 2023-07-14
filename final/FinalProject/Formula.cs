public class Formula : Menu
{
    public Formula(int largeB, int smallB) : base(largeB, smallB)
    {
        largeB = _largeB;
        smallB = _smallB;
    }

    public void GetBags()
    {
        double SB = Convert.ToDouble(_smallB);

        Boxes b1 = new Boxes();
        b1.GetBoxesTotal(GetTotalBags(_largeB, SB));

    }

    public int GetTotalBags(int LB, double SB)
    {
        double convertToLarge = SB * 0.625;
        int largeConverted = Convert.ToInt32(convertToLarge);
        int totalBags = largeConverted + LB;

        return totalBags;
    }
}