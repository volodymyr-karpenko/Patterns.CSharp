namespace Patterns.CSharp.Patterns.Strategy
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Context context;
            context = new Context(new ConcreteStrategyOne());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyTwo());
            context.ContextInterface();
        }
    }
}