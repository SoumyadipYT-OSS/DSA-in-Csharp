using System;

namespace BankAccountExample {
    class Program {
        static void Main(string[] args) {
            BankAccount account = new BankAccount("123456789", 1000.0);
            account.Deposit(500.0);
            account.Withdraw(200.0);

            InterestEarningAccount interestAccount = new InterestEarningAccount("987654321", 2000.0, 5.0);
            interestAccount.Deposit(300.0);
            interestAccount.Withdraw(100.0);
            interestAccount.ApplyInterest();

            LineOfCreditAccount creditAccount = new LineOfCreditAccount("1122334455", 3000.0, 1000.0);
            creditAccount.Deposit(500.0);
            creditAccount.Withdraw(3500.0);

            GiftCardAccount giftCardAccount = new GiftCardAccount("6677889900", 150.0);
            giftCardAccount.Deposit(50.0);
            giftCardAccount.ApplyGiftCardValue(100.0);
        }
    }
}