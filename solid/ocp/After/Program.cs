namespace After;

public static class Program
{
    public static void Main(string[] args)
    {
        var moment = DateTime.Now;
        Invoice finalInvoice = new FinalInvoice(10000, moment);
        Invoice proposedInvoice = new ProposedInvoice(10000, moment);
        Invoice recurringInvoice = new RecurringInvoice(10000, moment);
        var finalInvoiceAmount = finalInvoice.GetDiscount();
        var proposedInvoiceAmount = proposedInvoice.GetDiscount();
        var recurringInvoiceAmount = recurringInvoice.GetDiscount();
        
        //...
    }
}