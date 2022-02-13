namespace After;

public class ProposedInvoice : Invoice
{
    public ProposedInvoice(double amount, DateTime date)
        : base(amount, date)
    {
    }

    public override double GetDiscount()
    {
        return base.GetDiscount() - 40;
    }
}