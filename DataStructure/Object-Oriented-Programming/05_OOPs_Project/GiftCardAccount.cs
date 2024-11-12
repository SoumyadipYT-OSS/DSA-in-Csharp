using System;

namespace BankAccountExample {
    public class GiftCardAccount : BankAccount {
        public GiftCardAccount(string accountNumber, double initialBalance)
            : base(accountNumber, initialBalance) {
        }

        public void ApplyGiftCardValue(double amount) {
            Deposit(amount);
            Console.WriteLine($"Applied gift card value of {amount:C}. New balance: {Balance:C}");
        }
    }
}