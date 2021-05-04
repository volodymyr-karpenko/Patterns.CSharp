namespace Patterns.CSharp.Patterns.Bridge
{
    public class ConcreteImplementorTwo : Implementor
    {
        public override void OperationImp()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(OperationImp) + " => Concrete implementation of the Implementor's OperationImp is being called" + "\r\n\r\n";
        }
    }
}