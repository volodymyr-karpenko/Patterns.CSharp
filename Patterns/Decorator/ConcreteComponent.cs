namespace Patterns.CSharp.Patterns.Decorator
{
    public class ConcreteComponent : AbstractComponent
    {
        public override void Operation()
        {
            PatternUseCase.Output += GetType().Name + ": " + "\r\n\r\n";
        }
    }
}