namespace After;

public class LiquidInkjetPrinter : IPrinterTasks
{
    public void Print(string printContent)
    {
        Console.WriteLine("Print Done");
    }
    
    public void Scan(string scanContent)
    {
        Console.WriteLine("Scan content");
    }
}