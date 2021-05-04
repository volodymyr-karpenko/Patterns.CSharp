namespace Patterns.CSharp.Patterns.Command
{
    public abstract class AbstractCommand
    {
        protected Receiver receiver;

        public AbstractCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();

        public abstract void UndoExecution();
    }
}