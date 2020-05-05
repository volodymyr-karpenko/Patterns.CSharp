namespace Patterns.CSharp.Patterns.Bridge
{
    public class ConcreteImplementorOne : AbstractImplementor
    {
        public override void Operation()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(Operation) + "\r\n\r\n";
        }
    }
}