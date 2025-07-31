using System;

namespace StructType
{
    enum AccountType { Checking, Deposit };
    internal class Program
    {
        public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 12;
            goldAccount.accBal = 16;
            goldAccount.accType = AccountType.Checking;
            Console.WriteLine(goldAccount.accNo);
            Console.WriteLine(goldAccount.accBal);
            Console.WriteLine(goldAccount.accType);
        }
    }
}
