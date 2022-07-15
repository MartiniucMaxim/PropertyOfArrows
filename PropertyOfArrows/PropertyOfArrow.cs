using System;


class Arrow
{
    public enum ArrowHead
    {
        Wood,
        Obsidian,
        Steel,
        Null
    }

    public enum FletchingType
    {
        GooseFeathered,
        TurkeyFeathered,
        Plastic,
        Null
    }


    public ArrowHead arrowHead;
    public FletchingType fletchingType;
    public int length;
    public Arrow(ArrowHead arrowHead, FletchingType fletchingType, int length)
    {
        this.arrowHead = arrowHead;
        this.fletchingType = fletchingType;
        this.length = length;
    }
    public static int Length
    {
        get
        {
            int length = Convert.ToInt32(Console.ReadLine());
            if (length >= 60 && length <= 100)
            {
                Console.WriteLine($"Your arrow have length:{length}");
            }
            return length;
        }

        set
        {

        }
    }
    public float Cost
    {
        get
        {
            float arrowHeadCost = this.arrowHead switch
            {
                ArrowHead.Wood => 3f,
                ArrowHead.Obsidian => 5f,
                ArrowHead.Steel => 10f,
                ArrowHead.Null => 0f
            };

            float fletchingCost = this.fletchingType switch
            {
                FletchingType.GooseFeathered => 3f,
                FletchingType.TurkeyFeathered => 5f,
                FletchingType.Plastic => 10f,
                FletchingType.Null => 0f
            };
            float lengthCost = this.length * 0.05f;
            float totalCost = fletchingCost + arrowHeadCost + lengthCost;
            return totalCost;
        }
    }

    public static ArrowHead ArrowHeadType
    {
        get
        {
            int arrowHead = Convert.ToInt32(Console.ReadLine());
            switch (arrowHead)
            {
                case (int)ArrowHead.Wood:
                    Console.WriteLine($"Your arrows will have a {ArrowHead.Wood} arrowhead");
                    return ArrowHead.Wood;
                case (int)ArrowHead.Obsidian:
                    Console.WriteLine($"Your arrows will have an {ArrowHead.Obsidian} arrowhead");
                    return ArrowHead.Obsidian;
                case (int)ArrowHead.Steel:
                    Console.WriteLine($"Your arrows will have an {ArrowHead.Steel}");
                    return ArrowHead.Steel;
                default:
                    Console.WriteLine($"Your arrow have {ArrowHead.Null} arrowhead. You hadn't choose anything from Wood/Obsidian/Steel choice");
                    return ArrowHead.Null;
                    //break;
            }
        }
    }

    public static FletchingType FletchingTypeChoice
    {
        get
        {
            int fletchingType = Convert.ToInt32(Console.ReadLine()); ;
            switch (fletchingType)
            {
                case (int)FletchingType.GooseFeathered:
                    Console.WriteLine($"Your fletching type is {FletchingType.GooseFeathered}");
                    return FletchingType.GooseFeathered;
                case (int)FletchingType.TurkeyFeathered:
                    Console.WriteLine($"Your fletching type is {FletchingType.TurkeyFeathered}");
                    return FletchingType.TurkeyFeathered;
                case (int)FletchingType.Plastic:
                    Console.WriteLine($"Your fletching type is {FletchingType.Plastic}");
                    return FletchingType.Plastic;
                default:
                    Console.WriteLine($"Your fletching type is {FletchingType.Null}. Choose between Goose/Turkey/Plastic feathers.");
                    return FletchingType.Null;
                    //break;
            }
        }
    }

   

    public static void Main(String[]args)
    {
        Arrow myArrow = new Arrow(ArrowHeadType,FletchingTypeChoice,Length);
        Console.WriteLine($"The final price for arrows is:{myArrow.Cost}");
        
    }
}


