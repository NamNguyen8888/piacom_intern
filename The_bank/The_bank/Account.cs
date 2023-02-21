using System;
using System.Text;

/// <summary>
/// Summary description for Class1
/// </summary>

public class Account
{
    public static readonly string CHECKING = "CHECKING";
    public static readonly string SAVINGS = "SAVINGS";

    public string AccountNumber { get; }
    public decimal Balance { get; private set; }
    public List<Transaction> TransactionList { get; }

    public Account(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        TransactionList = new List<Transaction>();
    }

    public virtual void Deposit(decimal amount)
    {
        doDepositing(amount);
        addTransaction(new Transaction("Deposit", amount));
    }

    public virtual void Withdraw(decimal amount)
    {
        doWithdrawing(amount);
        addTransaction(new Transaction("Withdrawal", -amount));
    }

    protected virtual void doDepositing(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Cannot deposit a negative amount");
        }
        Balance += amount;
    }

    protected virtual void doWithdrawing(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Cannot withdraw a negative amount");
        }
        if (Balance < amount)
        {
            throw new InvalidOperationException("Insufficient balance");
        }
        Balance -= amount;
    }

    protected virtual void addTransaction(Transaction transaction)
    {
        TransactionList.Add(transaction);
    }

    public virtual string GetTransactionHistory()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Transaction history of account {AccountNumber}:");
        foreach (Transaction t in TransactionList)
        {
           }
        return sb.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Account other = (Account)obj;
        return AccountNumber == other.AccountNumber;
    }

    public override int GetHashCode()
    {
        return AccountNumber.GetHashCode();
    }
}
