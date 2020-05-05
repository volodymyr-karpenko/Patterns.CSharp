namespace Patterns.CSharp.Patterns.Bridge
{
    public class ConcreteImplementorTwo : AbstractImplementor
    {
        public override void Operation()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(Operation) + "\r\n\r\n";
        }
    }
}