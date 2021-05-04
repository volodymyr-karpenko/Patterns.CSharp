namespace Patterns.CSharp.Patterns.Command
{
    public class ConcreteCommand : AbstractCommand
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {

        }

        public override void Execute()
        {
            receiver.RespondToCommand();
        }

        public override void UndoExecution()
        {
            receiver.UndoRespondToCommand();
        }
    }
}