namespace Before;

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
            if (customer.Wallet.Money < Price) // violation of LoD: customer.Wallet.Money
            {
                continue;
            }
            
            customer.Wallet.Money -= Price;
            fundsCollected += Price;
        }
    }
}