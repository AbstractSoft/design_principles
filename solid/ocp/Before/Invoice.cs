namespace Before;

using System;

public class Invoice
{
    public Invoice(double amount, DateTime date)
    {
        Amount = amount;
        Date = date;
    }

    public double Amount { get; }
    public DateTime Date { get; }

    public double GetDiscount(InvoiceType invoiceType)
    {
        double finalAmount = 0;
        if (invoiceType == InvoiceType.FinalInvoice)
        {
            finalAmount = Amount - 100;
        }
        else if (invoiceType == InvoiceType.ProposedInvoice)
        {
            finalAmount = Amount - 50;
        }

        return finalAmount;
    }
}