namespace Patterns.CSharp.Patterns.Flyweight
{
    public class ConcreteFlyweightShared : AbstractFlyweight
    {
        private int intrinsicState;

        public override void Operation(int extrinsicState)
        {
            intrinsicState = extrinsicState;
            PatternUseCase.Output += GetType().Name + ": " + nameof(intrinsicState) + " = " + extrinsicState.ToString() + "\r\n\r\n";
        }
    }
}