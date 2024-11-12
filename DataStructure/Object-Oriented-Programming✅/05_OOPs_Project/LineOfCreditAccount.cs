using System;

namespace BankAccountExample {
    public class LineOfCreditAccount : BankAccount {
        private double _creditLimit;

        public LineOfCreditAccount(string accountNumber, double initialBalance, double creditLimit)
            : base(accountNumber, initialBalance) {
            _creditLimit = creditLimit;
        }

        public new void Withdraw(double amount) {
            if (amount > 0 && amount <= (Balance + _creditLimit)) {
                base.Withdraw(amount);
            } else {
                Console.WriteLine("Withdrawal amount exceeds credit limit.");
            }
        }
    }
}