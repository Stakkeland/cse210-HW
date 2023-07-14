public class Boxes
{
    //variables
    private int _fundraiserB;
    private int _largeB;
    private int _18x14x12;
    private int _16x12x10;
    private int _16x12x8;
    private int _14x10x8;
    private int _14x10x6;
    private int _12x10x4;
    private int _12x6x4;

    //constructor
    public Boxes()
    {
        _fundraiserB = 36;
        _largeB = 30;
        _18x14x12 = 24;
        _16x12x10 = 18;
        _16x12x8 = 12;
        _14x10x8 = 10;
        _14x10x6 = 7;
        _12x10x4 = 4;
        _12x6x4 = 2;

    }

    //functions
    public void GetBoxesTotal(int TotalBags)
    {
        int bagsAccounted = TotalBags;

        List<string> Boxes = new List<string>();

        while (bagsAccounted != 0)
        {
           if (bagsAccounted > _fundraiserB)
           {
                bagsAccounted = bagsAccounted - _fundraiserB;
                Boxes.Add("Fundraiser Box");  
           }
           else if(bagsAccounted > _largeB)
           {
                bagsAccounted = bagsAccounted - _fundraiserB;
                Boxes.Add("Fundraiser Box");  
           }
            else if(bagsAccounted > _18x14x12)
           {
                bagsAccounted = bagsAccounted - _largeB;
                Boxes.Add("Large Box");  
           }
            else if(bagsAccounted > _16x12x10)
           {
                bagsAccounted = bagsAccounted - _18x14x12;
                Boxes.Add("18x14x12");
           }
            else if(bagsAccounted > _16x12x8)
           {
                bagsAccounted = bagsAccounted - _16x12x10;
                Boxes.Add("16x12x10");
           }
            else if(bagsAccounted > _14x10x8)
           {
                bagsAccounted = bagsAccounted - _16x12x8;
                Boxes.Add("16x12x8");
           }
            else if(bagsAccounted > _14x10x6)
           {
                bagsAccounted = bagsAccounted - _14x10x8;
                Boxes.Add("14x10x8");
           }
            else if(bagsAccounted > _12x10x4)
           {
                bagsAccounted = bagsAccounted - _14x10x6;
                Boxes.Add("14x10x6");
           }
            else if(bagsAccounted > _12x6x4)
           {
                bagsAccounted = bagsAccounted - _12x10x4;
                Boxes.Add("12x10x4");
           }
            else if(bagsAccounted > 0)
           {
                bagsAccounted = bagsAccounted - _12x6x4;
                Boxes.Add("12x6x4");
           }
            else if (bagsAccounted < 0)
            {
                bagsAccounted = 0;
            }

        }

            int TotalBoxes = Boxes.Count();
            Console.WriteLine($"Total Boxes needed:{TotalBoxes}");
            Console.WriteLine("Box sizes:");
            
            foreach (string box in Boxes) 
            {
                Console.WriteLine($">{box}");
            }
    }


}