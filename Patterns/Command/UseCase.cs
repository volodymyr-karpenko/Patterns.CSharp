namespace Patterns.CSharp.Patterns.Command
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Receiver receiver = new Receiver();
            AbstractCommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            invoker.ExecuteCommand(command);
            invoker.UndoLastCommand();
        }
    }
}