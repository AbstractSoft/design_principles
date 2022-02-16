namespace After;

public class Paperboy
{
    // The newspaper costs $1
    private const decimal Price = 1m;
    
    private decimal fundsCollected=0;
    
    public Paperboy()
    {
        Customers = new List<Customer>();
    }
    
    public List<Customer> Customers { get; }
    
    public void CollectPayments()
    {
        foreach (var customer in Customers)
        {
            try
            {
                customer.MakePayment(Price);
            }
            catch (InvalidOperationException ex)
            {
                // Show the error and continue
                continue;
            }
            
            fundsCollected += Price;
        }
    }
}