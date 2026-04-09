namespace bank;

public abstract class BankAccount : BankingService, IComparable
{
    public decimal Balance { get; protected set; }

    public BankAccount(Owner owner) : base(owner)
    {
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }
    public abstract bool Withdraw(decimal amount);

    public BankCard NewCard(string cardNumber)
    {
        return new BankCard(this.Owner, this, cardNumber);
    }

    public int CompareTo(object? obj)
    {
        if (obj is BankAccount other)
        {
            return this.Balance.CompareTo(other.Balance);
        }

        throw new ArgumentException("Az objektum nem BankAccount típusú!");
    }
}
