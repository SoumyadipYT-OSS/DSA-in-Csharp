using System;

namespace BankAccountExample {
    public class InterestEarningAccount : BankAccount {
        private double _interestRate;

        public InterestEarningAccount(string accountNumber, double initialBalance, double interestRate)
            : base(accountNumber, initialBalance) {
            _interestRate = interestRate;
        }

        public void ApplyInterest() {
            double interest = Balance * _interestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Applied {_interestRate}% interest. New balance: {Balance:C}");
        }
    }
}