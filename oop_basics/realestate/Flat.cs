namespace realestate;

public abstract class Flat : IRealEstate
{
    protected double area;
    protected int roomsCount;
    protected int inhabitantsCount;
    protected int unitPrice;

    public int GetInhabitantsCount()
    {
        return this.inhabitantsCount;
    }

    public Flat(double area, int roomsCount, int unitPrice, int inhabitantsCount)
    {
        this.area = area;
        this.roomsCount = roomsCount;
        this.unitPrice = unitPrice;
        this.inhabitantsCount = inhabitantsCount;
    }

    public abstract bool MoveIn(int newInhabitants);

    public int TotalValue()
    {
        return (int)(area * unitPrice);
    }

    public override string ToString()
    {
        return $"Alapterület: {area} m2, Szobák: {roomsCount}, Lakók: {inhabitantsCount}, m2 ár: {unitPrice}";
    }
}