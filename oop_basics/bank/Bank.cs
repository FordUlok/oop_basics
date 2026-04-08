namespace bank;

public class Bank
{
    private BankAccount[] accounts;
    private int accountCount;

    public Bank(int maxAccounts)
    {
        accounts = new BankAccount[maxAccounts];
        accountCount = 0;
    }

    public BankAccount NewAccount(Owner owner, decimal creditLimit)
    {
        if (accountCount >= accounts.Length)
        {
            return null;
        }
        BankAccount newAcc;
        if (creditLimit > 0)
        {
            newAcc = new CreditAccount(owner, creditLimit);
        }
        else
        {
            newAcc = new SavingAccount(owner);
        }

        accounts[accountCount++] = newAcc;
        return newAcc;
    }

    public decimal TotalBalance(Owner owner)
    {
        decimal total = 0;
        for (int i = 0; i < accountCount; i++)
        {
            if (accounts[i].Owner == owner)
            {
                total += accounts[i].Balance;
            }
        }
        return total;
    }

    public BankAccount MaxBalanceAcc(Owner owner)
    {
        BankAccount maxAcc = null;
        for (int i = 0; i < accountCount; i++)
        {
            if (accounts[i].Owner == owner)
            {
                if (maxAcc == null || accounts[i].Balance > maxAcc.Balance)
                {
                    maxAcc = accounts[i];
                }
            }
        }
        return maxAcc;
    }

    public decimal TotalCreditLimit()
    {
        decimal totalLimit = 0;
        for (int i = 0; i < accountCount; i++)
        {
            if (accounts[i] is CreditAccount creditAccount)
            {
                totalLimit += creditAccount.creditLimit;
            }
        }
        return totalLimit;
    }
}