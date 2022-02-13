namespace After;

public class InvoiceService
{
    private readonly ILoggerService fileLoggerService;
    private readonly INotificationService emailService;
    private readonly IValidationService validationService;

    public InvoiceService(
        IValidationService validationService, 
        ILoggerService fileLoggerService, 
        INotificationService emailService)
    {
        this.validationService = validationService;
        this.fileLoggerService = fileLoggerService;
        this.emailService = emailService;
    }

    public void Add(Invoice invoice)
    {
        try
        {
            fileLoggerService.Info("Add method Start");
            
            validationService.Validate(invoice);
            
            // Here we need to write the Code for adding invoice
            // Once the Invoice has been added, then send the  mail
            
            emailService.From = "emailfrom@xyz.com";
            emailService.To = "emailto@xyz.com";
            emailService.Subject = "Single Responsibility Princile";
            emailService.Body = "A class should have only one reason to change";
            emailService.SendEmail();
        }
        catch (Exception ex)
        {
            fileLoggerService.Error("Error Occurred while Generating Invoice", ex);
        }
    }

    public void Delete(Invoice invoice)
    {
        try
        {
            validationService.Validate(invoice);
                
            //Here we need to write the Code for Deleting the already generated invoice
            fileLoggerService.Info("Delete Invoice Start at @" + DateTime.Now);
        }
        catch (Exception ex)
        {
            fileLoggerService.Error("Error Occurred while Deleting Invoice", ex);
        }
    }
}