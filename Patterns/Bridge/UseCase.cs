namespace Patterns.CSharp.Patterns.Bridge
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Abstraction abstraction;

            abstraction = new RefinedAbstraction(new ConcreteImplementorOne());
            abstraction.Operation();

            abstraction = new RefinedAbstraction(new ConcreteImplementorTwo());
            abstraction.Operation();
        }        
    }
}