namespace After;

public static class Program
{
    public static void Main(string[] args)
    {
        var invoiceService = new InvoiceService(
            new ValidationService(), 
            new LoggerServiceService(), 
            new EmailService());
    }
}
