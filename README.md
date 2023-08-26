# DeferExpression
Defer from Zig in C#. Cursed as hell.

```csharp
    public static void Main()
    {
        using var d1 = new Defer(() => Console.WriteLine("1"));
        using var d2 = new Defer(() => Console.WriteLine("2"));
        using var d3 = new Defer(() => Console.WriteLine("3"));
        using var d4 = new Defer(() => Console.WriteLine("4"));
        
        Console.WriteLine("Hello, World!");
        
        using var d5 = new Defer(() => Console.WriteLine("5"));
    }
```
Outputs:
```
Hello, World!
5
4
3
2
1
```

Or you can use the stack version for the same result:
```csharp
    public static void Main()
    {
        using DeferStack stack = new(capacity: 5);
        
        stack.Defer(() => Console.WriteLine("1"));
        stack.Defer(() => Console.WriteLine("2"));
        stack.Defer(() => Console.WriteLine("3"));
        stack.Defer(() => Console.WriteLine("4"));
        Console.WriteLine("Hello, World!");
        stack.Defer(() => Console.WriteLine("5"));
    }
```
