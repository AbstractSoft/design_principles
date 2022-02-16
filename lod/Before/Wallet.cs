namespace Before;

public class Wallet
{
    public Wallet(decimal money)
    {
        Money = money;
    }

    public decimal Money { get; set; }
}