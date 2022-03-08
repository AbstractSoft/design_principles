namespace Before;

public class InkPrinter : IPrinterTasks
{
    public void Print(string printContent)
    {
        Console.WriteLine("Print Done");
    }
    
    public void Scan(string scanContent)
    {
        Console.WriteLine("Scan content");
    }
    
    public void Fax(string faxContent)
    {
        throw new NotImplementedException();
    }
    
    public void PrintDuplex(string printDuplexContent)
    {
        throw new NotImplementedException();
    }
}