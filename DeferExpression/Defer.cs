namespace DeferExpression;

public class Defer : IDisposable
{
    private readonly Action _action;
    
    public Defer(Action action)
    {
        this._action = action;
    }

    public void Dispose()
    {
        _action.Invoke();
        GC.SuppressFinalize(this);
    }
}