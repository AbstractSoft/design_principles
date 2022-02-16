namespace Before;

public class Customer
{
    public Customer() : 
        this(new Wallet(0)) { }
    
    public Customer(Wallet wallet)
    {
        Wallet = wallet;
    }
    
    public Wallet Wallet { get; }
}