namespace After;

public static class Program
{
    static void Main(string[] args)
    {
        Fruit fruit = new Orange();
        Console.WriteLine(fruit.GetColor());
        
        fruit = new Apple();
        Console.WriteLine(fruit.GetColor());
    }
}