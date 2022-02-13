namespace After;

using System;

public abstract class Invoice
{
    protected Invoice(double amount, DateTime date)
    {
        Amount = amount;
        Date = date;
    }

    public double Amount { get; }
    public DateTime Date { get; }

    public virtual double GetDiscount()
    {
        return Amount - 10;
    }
}