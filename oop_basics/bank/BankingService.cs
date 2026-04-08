namespace bank;

public abstract class BankingService
{
    public Owner Owner { get; }

    public BankingService(Owner owner)
    {
        Owner = owner;
    }
}