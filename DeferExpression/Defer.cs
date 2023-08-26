namespace DeferExpression;

public class Defer : IDisposable
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
        if (!_alreadyRan)
        {
            _action.Invoke();
            _alreadyRan = true;
        }
        GC.SuppressFinalize(this);
    }
}