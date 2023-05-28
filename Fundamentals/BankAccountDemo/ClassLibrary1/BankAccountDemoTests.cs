using BankAccountDemo;
using NUnit.Framework;


namespace BankTests
{
    [TestFixture]
    public class BankAccountDemoTests
    {
        private BankAccount positiveAccount;
        [SetUp]
        public void Setup()
        {
            this.positiveAccount = new BankAccount(1000);
        }
        [Test]
        [Category("Critical")]
        public void CreateAccountWithPositiveValue()
        {
            Assert.AreEqual(1000, positiveAccount.Amount);
        }
        [Test]
        [Category("Medium")]
        public void AccountDeposit500()
        {
            positiveAccount.Deposit(500);
            Assert.AreEqual(1500, positiveAccount.Amount);
        }
        [Test]
        [Category("Low")]
        public void AccountWithdrawLessThan1000()
        {
            positiveAccount.Withdraw(200);
            Assert.AreEqual(790, positiveAccount.Amount);
        }
        [Test]
        [Category("Critical")]
        public void AccountWithNegativeCheckException()
        {
            TestDelegate negativeAccount = () => new BankAccount(-1000);
            Assert.Throws < ArgumentException>(negativeAccount);
        }

    }
}