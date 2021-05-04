namespace Patterns.CSharp.Patterns.State
{
    public class ConcreteStateTwo : AbstractState
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateOne();
            PatternUseCase.Output += "State of " + context.GetType().Name + ": " + context.State.GetType().Name + "\r\n\r\n";
        }
    }
}