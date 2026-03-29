namespace ConsoleApp.Patterns.FactoryMethod
{
    public class ConcreteCreatorOne : AbstractCreator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProductOne();
        }
    }
}