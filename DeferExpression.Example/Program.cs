using DeferExpression;

using Defer _ = new Defer(() => Console.WriteLine("Defer"));
Console.WriteLine("Hello, World!");