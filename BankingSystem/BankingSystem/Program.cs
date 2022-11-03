using BankingSystem.Entities;
using System;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account = new BankAccount("Amey", 1000);
                Console.WriteLine($"Account {account.Number} was created for " +
                    $"{account.Owner} with {account.Balance} initial balance.");

                account.MakeDeposit(100, DateTime.Now, "Amazon refund");
                Console.WriteLine(account.Balance);

                account.MakeDeposit(100, DateTime.Now, "HDFC cashback");
                Console.WriteLine(account.Balance);

                account.MakeDeposit(100, DateTime.Now, "SBI redeem points checkout");
                Console.WriteLine(account.Balance);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            // Test that the initial balances must be positive.
            try
            {
                var invalidAccount = new BankAccount("invalid", -49);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }

            Console.ReadKey();
        }
    }
}