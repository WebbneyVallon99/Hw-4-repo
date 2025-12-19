using System;
using System.Collections.Generic;

public class BankAccount
{
    // Instance Variables (Private Fields)
    private string accountID;
    private string customerName;
    private decimal balance;
    private List<string> transactions;

    // Properties (Public Accessors)
    public string AccountID => accountID;
    public string CustomerName => customerName;
    public decimal Balance => balance;
    public List<string> Transactions => new List<string>(transactions); // Return a copy for safety

    // Constructor
    public BankAccount(string name, decimal initialBalance)
    {
        customerName = name;
        // Generate a simple unique ID
        accountID = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        balance = initialBalance;
        transactions = new List<string>();
        transactions.Add($"Account created with initial balance of ${initialBalance}");
    }

    public bool Deposit(decimal amount)
    {
        if (amount <= 0) return false;
        
        balance += amount;
        transactions.Add($"Deposited: ${amount}. New Balance: ${balance}");
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || amount > balance) return false;

        balance -= amount;
        transactions.Add($"Withdrew: ${amount}. New Balance: ${balance}");
        return true;
    }
}