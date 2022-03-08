namespace Before;

public class LaserPrinter : IPrinterTasks
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
        Console.WriteLine("Fax content");
    }
    
    public void PrintDuplex(string printDuplexContent)
    {
        Console.WriteLine("Print Duplex content");
    }
}