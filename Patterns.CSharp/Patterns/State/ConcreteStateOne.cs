namespace Patterns.CSharp.Patterns.State
{
    public class ConcreteStateOne : AbstractState
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateTwo();
            PatternUseCase.Output += "State of " + context.GetType().Name + ": " + context.State.GetType().Name + "\r\n\r\n";
        }
    }
}