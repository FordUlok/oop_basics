namespace realestate;

public interface IRent
{
    int GetCost(int months);

    bool IsBooked();
    
    bool Book(int months);
}