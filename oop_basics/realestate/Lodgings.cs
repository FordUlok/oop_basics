namespace realestate;

public class Lodgings : Flat, IRent
{
    private int bookedMonths;


    public Lodgings(double area, int roomsCount, int unitPrice) : base(area, 
        roomsCount, unitPrice, 0)
    {
        bookedMonths = 0;
    }

    public int GetCost(int months)
    {
        return months * this.unitPrice / 240 / this.inhabitantsCount;
    }
    public bool IsBooked()
    {
        return this.bookedMonths != 0;
    }
    
    public bool Book(int months)
    {
        if (!IsBooked())
        {
            this.bookedMonths = months;
            return true;
        }
        else
        {
            return false;
        }
    }
    public override bool MoveIn(int newInhabitants)
    {
        if (IsBooked() && (inhabitantsCount + newInhabitants < roomsCount * 8) && 2 < (area / (inhabitantsCount + newInhabitants)))
        {
            inhabitantsCount += newInhabitants;
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public override string ToString()
    {
        return base.ToString() + $", foglalt hónapok száma: {bookedMonths}";
    }
}