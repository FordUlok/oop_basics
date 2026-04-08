namespace bank;

public class SavingAccount : BankAccount
{
    public static double DefaultInterestRate = 0.05;
    public double InterestRate { get; set; }

    public SavingAccount(Owner owner) : base(owner)
    {
        this.InterestRate = DefaultInterestRate;
    }

    public override bool Withdraw(decimal amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public void AddInterest()
    {
        decimal interest = Balance * (decimal)InterestRate;
        Deposit(interest);
    }
    
}