namespace Patterns.CSharp.Patterns.Decorator
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractComponent component = new ConcreteComponent();
            AbstractDecorator decorator1 = new ConcreteDecoratorOne();
            AbstractDecorator decorator2 = new ConcreteDecoratorTwo();

            decorator1.Component = component;
            decorator2.Component = decorator1;
            decorator2.Operation();
        }
    }
}