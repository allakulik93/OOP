using System;

/// <summary>
///    Test harness.
/// </summary>

public class Test
{
	public static void Main()
	{
        BankAccount b1 = new BankAccount();
        BankAccount b2 = new BankAccount();

        b1.Populate(100);
        b2.Populate(100);

        Console.WriteLine("Account Type is: {0}, account Number is: {1}, account Balance is: {2}.", b1.Type(), b1.Number(), b1.Balance());
        Console.WriteLine("Account Type is: {0}, account Number is: {1}, account Balance is: {2}.", b2.Type(), b2.Number(), b2.Balance());

        b1.TransferForm(ref b2, 10);

        Console.WriteLine("Account Type is: {0}, account Number is: {1}, account Balance is: {2}.", b1.Type(), b1.Number(), b1.Balance());
        Console.WriteLine("Account Type is: {0}, account Number is: {1}, account Balance is: {2}.", b2.Type(), b2.Number(), b2.Balance());
    }


}
