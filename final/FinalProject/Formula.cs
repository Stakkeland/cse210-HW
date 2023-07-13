public class Formula
{
    public Formula()
    {

    }

    public void GetBags()
    {
        Menu m1 = new Menu();
        int LB = m1.GetLargeB();
        double SB = m1.GetSmallB();

        Formulate(LB, SB);

    }

    public void Formulate(int LB, double SB)
    {
        double convertToLarge = SB * 0.625;
        int largeConverted = Convert.ToInt32(convertToLarge);
        int totalBags = largeConverted + LB;
    }
}