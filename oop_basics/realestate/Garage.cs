namespace realestate;

public class Garage : IRent, IRealEstate
{
    private double area;
    private int unitPrice;
    private bool isHeated;
    private int months;
    private bool isOccupied;

    public Garage(double area, int unitPrice, bool isHeated,
        int months, bool isOccupied)
    {
        this.area = area;
        this.unitPrice = unitPrice;
        this.isHeated = isHeated;
        this.months = months;
        this.isOccupied = isOccupied;
    }
    
    public int TotalValue()
    {
        return (int)(area * unitPrice);
    }
    
    public int GetCost(int months)
    {
        if (isHeated)
        {
            return(int)(months * TotalValue() / 120 * 1.5);
        }

        return (months * TotalValue() / 120);
    }

    public bool IsBooked()
    {
        return months > 0 || isOccupied;
    }

    public bool Book(int months)
    {
        if (!IsBooked())
        {
            this.months = months;
            return true;
        }
        return false;
    }
    
    public override string ToString()
    {
        return $"Alapterület: {area} m2, ár/m2: {unitPrice}, fűtött: {isHeated} foglalva: {months}, áll-e benne autó: {isOccupied}";
    }

    
}