namespace After;

public class RecurringInvoice : Invoice
{
    public RecurringInvoice(double amount, DateTime date)
        : base(amount, date)
    {
    }

    public override double GetDiscount()
    {
        return base.GetDiscount() - 30;
    }
}