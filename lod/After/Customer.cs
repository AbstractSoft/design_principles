namespace After;

public class Customer
{
    public Customer() : 
        this(new Wallet(0)) { }
    
    public Customer(Wallet wallet)
    {
        Wallet = wallet;
    }
    
    public Wallet Wallet { get; }
    
    public void MakePayment(decimal amount)
    {
        if (Wallet.Money < amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        
        Wallet.Money -= amount;
    }
}