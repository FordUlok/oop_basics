namespace realestate;

public class FamilyApartment : Flat
{
    private int childrenCount;

    public FamilyApartment(double area, int roomsCount, int unitPrice) : base(area,
        roomsCount, unitPrice, 0)
    {
        childrenCount = 0;
    }

    public bool ChildIsBorn()
    {
        if ((inhabitantsCount - childrenCount) >= 2)
        {
            inhabitantsCount++;
            childrenCount++;
            return true;
        }
        else
        {
            return false;
        }
    }
    

    public override bool MoveIn(int newInhabitants)
    {
        int totalAfterMove = inhabitantsCount + newInhabitants;
        int adultCount = totalAfterMove - childrenCount;
        double effectivePeople = adultCount + (childrenCount * 0.5);
        double requiredArea = adultCount * 10 + childrenCount * 5;

        if (effectivePeople <= roomsCount * 2 && area >= requiredArea)
        {
            inhabitantsCount = totalAfterMove;
            return true;
        }
        return false;
    }
    
    public override string ToString()
    {
        return base.ToString() + $", gyerekek száma: {childrenCount}";
    }
}