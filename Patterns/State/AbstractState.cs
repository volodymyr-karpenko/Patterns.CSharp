namespace Patterns.CSharp.Patterns.State
{
    public abstract class AbstractState
    {
        public abstract void Handle(Context context);
    }
}