namespace DeferExpression;

public struct DeferStack : IDisposable
{
    private bool _alreadyRan;
    private readonly Stack<Action> _actions;
    
    public DeferStack()
    {
        this._actions = new Stack<Action>();
    }

    public DeferStack(int capacity)
    {
        this._actions = new Stack<Action>(capacity);
    }

    public void Defer(Action action)
    {
        _actions.Push(action);
    }

    public void Dispose()
    {
        // prevent accidental double run
        if (_alreadyRan) return;
        _alreadyRan = true;
        
        foreach (Action action in _actions)
        {
            action.Invoke();
        }
        this._actions.Clear();
    }
}