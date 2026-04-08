namespace bank;

public class BankCard : BankingService
{
    public string CardNumber { get; }
    public BankAccount Account { get; }
    
    public BankCard(Owner owner, BankAccount account, string cardNumber) : base(owner)
    {
        Account = account;
        CardNumber = cardNumber;
    }

    public bool Purchase(decimal amount)
    {
        return Account.Withdraw(amount);
    }
}