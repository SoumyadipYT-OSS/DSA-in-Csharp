using System;

public class BankAccount {
    private decimal balance;

    public void Deposit(decimal amt) {
        if (amt > 0) {
            balance = balance + amt;
        }
        Console.WriteLine("Deposited...\nBalance: " + GetBalance());        // encapsulated: here GetBalance() is private, so it is called through Deposit function
    }

    private decimal GetBalance() {
        return balance;
    }


    // main method
    static void Main() {
        int deposit = 1000;
        BankAccount bank_accountObj = new BankAccount();
        bank_accountObj.Deposit(deposit);
    }
}