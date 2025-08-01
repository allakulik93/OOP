
class BankAccount 
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    
    private static long nextNumber = 123;

    public void Populate(decimal balance)
    {
        accNo = NextNumber();
        accBal = balance;
        accType = AccountType.Checking;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) {
            accBal -= amount;
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }
    
    private static long NextNumber()
    {
        return nextNumber++;
    }
    public void TransferForm(ref BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
        {
            this.Deposit(amount);
        }
    }
}
