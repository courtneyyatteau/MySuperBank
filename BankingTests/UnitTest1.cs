using Xunit;
using System;
using BankLibrary;

namespace BankingTests
{
    public class UnitTest1
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeOutMoreThanBalance()
        {
            var account = new BankAccount("Courtney", 10000);
            //test for negative balance
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(800, DateTime.Now, "Attempt to overdraw")
            );

            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance.");
            //    Console.WriteLine(e.ToString());
            //}
        }

        [Fact]
        public void NeedMoneyToMakeAccount()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => (new BankAccount("Courtney", -10000))
            );
        }
    }
}