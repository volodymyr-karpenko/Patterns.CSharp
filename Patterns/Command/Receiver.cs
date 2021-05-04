namespace Patterns.CSharp.Patterns.Command
{
    public class Receiver
    {
        public void RespondToCommand()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(RespondToCommand) + "\r\n\r\n";
        }

        public void UndoRespondToCommand()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(UndoRespondToCommand) + "\r\n\r\n";
        }
    }
}