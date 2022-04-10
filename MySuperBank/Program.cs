using BankLibrary;
using System;

namespace BankLibrary
{
    public class MySuperBank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("octopus");

            var account = new BankAccount("Courtney", 12340);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(10, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");
            account.MakeWithdrawal(10, DateTime.Now, "Chili");
            account.MakeWithdrawal(5, DateTime.Now, "Game");
            account.MakeWithdrawal(1200, DateTime.Now, "Poster");
            account.MakeWithdrawal(51, DateTime.Now, "PS Game");
            account.MakeWithdrawal(110, DateTime.Now, "Coke");
            account.MakeWithdrawal(53, DateTime.Now, "Lunch");
            Console.WriteLine(account.GetAccountHistory());

           

        }
    }
}