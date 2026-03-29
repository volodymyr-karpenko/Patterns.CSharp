namespace ConsoleApp.Patterns.FactoryMethod
{
    public class ConcreteCreatorTwo : AbstractCreator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProductTwo();
        }
    }
}