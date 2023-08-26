namespace DeferExpression;

public struct Defer : IDisposable
{
    private bool _alreadyRan;
    private readonly Action _action;
    
    public Defer(Action action)
    {
        this._action = action;
    }

    public void Dispose()
    {
        // prevent accidental double run
        if (_alreadyRan) return;
        _alreadyRan = true;
        
        _action.Invoke();
    }
}