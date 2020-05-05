namespace Patterns.CSharp.Patterns.Command
{
    public abstract class AbstractCommand
    {
        protected Receiver resiver;

        public AbstractCommand(Receiver resiver)
        {
            this.resiver = resiver;
        }

        public abstract void Execute();

        public abstract void UndoExecution();
    }
}