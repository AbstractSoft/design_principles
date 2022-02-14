namespace Before;

public static class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Orange();
        Console.WriteLine(apple.GetColor());
    }
}