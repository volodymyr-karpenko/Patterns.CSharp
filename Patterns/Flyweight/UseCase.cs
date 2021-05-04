namespace Patterns.CSharp.Patterns.Flyweight
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            int extrinsicState = 0;

            AbstractFlyweight flyweight;
            FlyweightFactory factory = new FlyweightFactory();

            flyweight = factory.GetFlyweight("1");
            flyweight.Operation(extrinsicState);

            flyweight = factory.GetFlyweight("10");
            flyweight.Operation(extrinsicState);

            flyweight = new ConcreteFlyweightUnshared();
            flyweight.Operation(extrinsicState);
        }
    }
}