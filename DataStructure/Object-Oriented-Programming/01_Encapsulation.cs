using System;

public class BankAccount {
    private decimal balance;

    public void Deposit(decimal amt) {
        if (amt > 0) {
            balance = balance + amt;
        }
    }

    public decimal GetBalance() {
        return balance;
    }


    // main method
    static void Main() {
        int deposit = 1000;
        BankAccount bank_accountObj = new BankAccount();
        bank_accountObj.Deposit(deposit);
        Console.WriteLine("Balance: " + bank_accountObj.GetBalance());
    }
}