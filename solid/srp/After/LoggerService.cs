namespace After;

public class LoggerService : ILoggerService
{
    public LoggerService()
    {
        // here we need to write the Code for initialization 
        // that is Creating the Log file with necesssary details
    }
    public void Info(string info)
    {
        // here we need to write the Code for info information into the ErrorLog text file
    }
    public void Debug(string info)
    {
        // here we need to write the Code for Debug information into the ErrorLog text file
    }
    public void Error(string message, Exception ex)
    {
        // here we need to write the Code for Error information into the ErrorLog text file
    }
}