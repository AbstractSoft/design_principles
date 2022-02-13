namespace After;

public interface INotificationService
{
    string From { get; set; }
    string To { get; set; }
    string Subject { get; set; }
    string Body { get; set; }
    void SendEmail();
}