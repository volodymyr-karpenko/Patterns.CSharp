namespace Patterns.CSharp.Patterns.FactoryMethod
{
    public class ConcreteCreatorTwo : AbstractCreator
    {
        public override AbstractProduct FactoryMethod()
        {
            return new ConcreteProductTwo();
        }
    }
}