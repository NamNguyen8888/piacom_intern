using System;


public class Transaction
{
    private string v;
    private decimal amount;

    public Transaction(string v, decimal amount)
    {
        this.v = v;
        this.amount = amount;
    }

    public object Type { get; internal set; }
}