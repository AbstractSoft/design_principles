namespace After;

public class FinalInvoice : Invoice
{
    public FinalInvoice(double amount, DateTime date)
        : base(amount, date)
    {
    }

    public override double GetDiscount()
    {
        return base.GetDiscount() - 50;
    }
}