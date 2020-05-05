namespace Patterns.CSharp.Patterns.Strategy
{
    public class ConcreteStrategyTwo : AbstractStrategy
    {
        public override void AlgorithmInterface()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(AlgorithmInterface) + "\r\n\r\n";
        }
    }
}