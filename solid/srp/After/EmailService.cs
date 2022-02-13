namespace After;

public class EmailService : INotificationService
{
    public EmailService()
    {
        From = string.Empty;
        To = string.Empty;
        Subject = string.Empty;
        Body = string.Empty;
    }
    
    public string From { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }

    public void SendEmail()
    {
        // Here we need to write the Code for sending the mail
    }
}