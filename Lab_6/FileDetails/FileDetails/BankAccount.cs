using System;
class BankAccount
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }
    public long Number()
    {
        return accNo;
    }
    public decimal Balance()
    {
        return accBal;
    }
    public AccountType Type()
    {
        return accType;
    }
    private long NextNumber()
    {
        return nextAccNo++;
    }
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }
    public bool Withdraw(decimal amount)
    {
        if (accBal >= amount)
        {
            accBal -= amount;
            return true;
        }
        return false;
    }
}
