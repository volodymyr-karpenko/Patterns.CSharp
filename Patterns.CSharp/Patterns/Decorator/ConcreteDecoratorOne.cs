namespace Patterns.CSharp.Patterns.Decorator
{
    public class ConcreteDecoratorOne : AbstractDecorator
    {
        private string addedState = "Added State";

        public override void Operation()
        {
            base.Operation();
            PatternUseCase.Output += addedState + "\r\n\r\n";
        }
    }
}