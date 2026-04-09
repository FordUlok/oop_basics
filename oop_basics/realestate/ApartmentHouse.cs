namespace realestate;

public class ApartmentHouse
{
    private int actualFlat;
    private int actualGarage;

    private int maxFlat;
    private int maxGarage;

    public List<IRealEstate> RealEstates { get; private set; }

    public ApartmentHouse(int maxFlat, int maxGarage)
    {
        this.actualFlat = 0;
        this.actualGarage = 0;
        this.maxFlat = maxFlat;
        this.maxGarage = maxGarage;
        RealEstates = new List<IRealEstate>();
    }

    public bool Create(IRealEstate ingatlan)
    {
        if (ingatlan is Flat)
        {
            if (actualFlat < maxFlat)
            {
                RealEstates.Add(ingatlan);
                actualFlat++;
                return true;
            }
                
        }else if (ingatlan is Garage)
        {
            if (actualGarage < maxGarage)
            {
                RealEstates.Add(ingatlan);
                actualGarage++;
                return true;
            }
        }
        return false;
    }

    public int InhabitantsCount()
    {
        int n = 0;
        for (int i = 0; i < RealEstates.Count; i++)
        {
            if (RealEstates[i] is Flat)
            {
                Flat temp = (Flat)RealEstates[i];
                n += temp.GetInhabitantsCount();
            }
        }
        return n;
    }

    public int TotalValue()
    {
        int n = 0;
        for (int i = 0; i < RealEstates.Count; i++)
        {
            if (RealEstates[i] is Flat)
            {
                Flat temp = (Flat)RealEstates[i];

                if (temp.GetInhabitantsCount() > 0)
                {
                    n += temp.TotalValue();
                }
            }
            else
            {
                Garage temp = (Garage)RealEstates[i];

                if (temp.IsBooked())
                {
                    n += temp.TotalValue();
                }
            }
        }

        return n;
    }
}