using System;

namespace BankAccountExample {
    public class BankAccount {
        private string _accountNumber;
        private double _balance;

        public BankAccount(string accountNumber, double initialBalance) {
            _accountNumber = accountNumber;
            _balance = initialBalance;
        }

        public string AccountNumber => _accountNumber;
        public double Balance => _balance;

        public void Deposit(double amt) {
            if (amt > 0) {
                _balance += amt;
                Console.WriteLine($"Deposited {amt:C} into account {_accountNumber}. New balance: {_balance:C}");
            } else {
                Console.WriteLine("Deposite amount must be positive.");
            }
        }

        public void Withdraw(double amt) {
            if (amt > 0  &&  amt <= _balance) {
                _balance -= amt;
                Console.WriteLine($"Withdrew {amt:C} from account {_accountNumber}. New balance: {_balance:C}");
            } else {
                Console.WriteLine("Invalid withdrawl amount.");
            }
        }
    }
}