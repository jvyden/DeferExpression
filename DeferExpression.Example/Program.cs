namespace DeferExpression.Example;

public static class Program
{
    public static void Main()
    {
        using var d1 = new Defer(() => Console.WriteLine("1"));
        using var d2 = new Defer(() => Console.WriteLine("2"));
        using var d3 = new Defer(() => Console.WriteLine("3"));
        using var d4 = new Defer(() => Console.WriteLine("4"));
        
        Console.WriteLine("Hello, World!");
        
        using var d5 = new Defer(() => Console.WriteLine("5"));
    }
}