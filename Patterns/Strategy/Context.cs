namespace Patterns.CSharp.Patterns.Strategy
{
    public class Context
    {
        private AbstractStrategy strategy;

        public Context(AbstractStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}