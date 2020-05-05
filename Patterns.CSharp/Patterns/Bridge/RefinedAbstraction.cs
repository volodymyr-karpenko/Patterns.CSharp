namespace Patterns.CSharp.Patterns.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(AbstractImplementor implementor) : base(implementor)
        {

        }

        public override void Operation()
        {
            // Add behavior
            PatternUseCase.Output += "RefinedAbstraction => Add behavior BEFORE operation from Implementor \r\n\r\n";

            base.Operation();

            // Add behavior
            PatternUseCase.Output += "RefinedAbstraction => Add behavior AFTER operation from Implementor \r\n\r\n";
        }
    }
}