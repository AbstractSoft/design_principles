namespace Before;

public interface IPrinterTasks
{
    void Print(string printContent);
    void Scan(string scanContent);
    void Fax(string faxContent);
    void PrintDuplex(string printDuplexContent);
}