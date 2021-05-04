namespace Patterns.CSharp.Patterns.ChainOfResponsibility
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractHandler handler1 = new ConcreteHandlerOne();
            handler1.Successor = new ConcreteHandlerTwo();
            handler1.HandleRequest(2);
        }
    }
}