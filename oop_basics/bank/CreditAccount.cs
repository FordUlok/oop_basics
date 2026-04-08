namespace bank;

public class CreditAccount : BankAccount
{
    public decimal creditLimit { get; }
    
    public CreditAccount(Owner owner, decimal limit) : base(owner)
    {
        creditLimit = limit;
    }

    public override bool Withdraw(decimal amount)
    {
        if (Balance - amount >= 0)
        {
            return true;
        }
        return false;
    }
}