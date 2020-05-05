namespace Patterns.CSharp.Patterns.Decorator
{
    public class ConcreteDecoratorTwo : AbstractDecorator
    {
        private void AddedBehavior()
        {
            PatternUseCase.Output += "Added Behavior" + "\r\n\r\n";
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}