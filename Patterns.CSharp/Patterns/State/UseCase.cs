namespace Patterns.CSharp.Patterns.State
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Context context = new Context(new ConcreteStateTwo());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}