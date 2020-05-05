namespace Patterns.CSharp.Patterns.Command
{
    public class ConcreteCommand : AbstractCommand
    {
        public ConcreteCommand(Receiver resiver) : base(resiver)
        {

        }

        public override void Execute()
        {
            resiver.RespondToCommand();
        }

        public override void UndoExecution()
        {
            resiver.UndoRespondToCommand();
        }
    }
}