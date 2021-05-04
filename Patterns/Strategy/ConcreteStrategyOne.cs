namespace Patterns.CSharp.Patterns.Strategy
{
    public class ConcreteStrategyOne : AbstractStrategy
    {
        public override void AlgorithmInterface()
        {
            PatternUseCase.Output += GetType().Name + " => " + nameof(AlgorithmInterface) + "\r\n\r\n";
        }
    }
}