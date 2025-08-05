using System;

namespace Classes_M1
{
    public class BankAccount
    {
        // Static interest rate (shared by all accounts)
        public static double InterestRate = 0.015;

        // Static account number tracker
        private static int s_nextAccountNumber = 1000000;

        // Public fields
        public readonly string AccountNumber;
        public readonly string CustomerId;
        public double Balance;
        public string AccountType;

        // Constructor with only CustomerId
        public BankAccount(string customerId)
        {
            this.AccountNumber = (s_nextAccountNumber++).ToString();
            this.CustomerId = customerId;
            this.Balance = 0.0;
            this.AccountType = "Savings"; // default account type
        }

        // Constructor with CustomerId, balance, and account type
        public BankAccount(string customerId, double balance, string accountType)
        {
            this.AccountNumber = (s_nextAccountNumber++).ToString();
            this.CustomerId = customerId;
            this.Balance = balance;
            this.AccountType = accountType;
        }
    }
}
