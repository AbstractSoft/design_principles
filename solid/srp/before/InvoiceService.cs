namespace Before;

using System.Net.Mail;

public class InvoiceService
{
    public void Add(Invoice invoice)
    {
        try
        {
            Validate(invoice);

            // Here we need to write the Code for adding invoice
            // Once the Invoice has been added, then send the  mail

            var mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");

            SendEmail(mailMessage);
        }
        catch (Exception ex)
        {
            //Error Logging
            File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
        }
    }

    public void Delete(Invoice invoice)
    {
        try
        {
            Validate(invoice);

            //Here we need to write the Code for Deleting the already generated invoice
        }
        catch (Exception ex)
        {
            //Error Logging
            File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
        }
    }

    public void Validate(Invoice invoice)
    {
        try
        {
            // Here we need to write the Code for invoice validation
        }
        catch (Exception ex)
        {
            //Error Logging
            File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
        }
    }

    public void SendEmail(MailMessage mailMessage)
    {
        try
        {
            // Here we need to write the Code for Email setting and sending the invoice mail
        }
        catch (Exception ex)
        {
            //Error Logging
            File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
        }
    }
}