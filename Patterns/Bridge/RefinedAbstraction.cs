namespace Patterns.CSharp.Patterns.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor)
        {

        }

        public override void Operation()
        {
            //Concrete implementation of the Implementor's OperationImp is being called
            base.Operation();

            // Concrete implementation of the Abstraction's Operation is being called
            PatternUseCase.Output += GetType().Name + " => Concrete implementation of the Abstraction's Operation is being called \r\n\r\n";
        }
    }
}