namespace Patterns.CSharp.Patterns.Flyweight
{
    public class ConcreteFlyweightUnshared : AbstractFlyweight
    {
        private int allState;        

        public override void Operation(int extrinsicState)
        {
            allState = extrinsicState;
            PatternUseCase.Output += GetType().Name + ": " + nameof(allState) + " = " + extrinsicState.ToString() + "\r\n\r\n";
        }
    }
}