namespace Patterns.CSharp.Patterns.ChainOfResponsibility
{
    public abstract class AbstractHandler
    {
        public AbstractHandler Successor { get; set; }

        public abstract void HandleRequest(int request);
    }
}