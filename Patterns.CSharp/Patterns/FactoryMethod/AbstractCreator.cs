namespace Patterns.CSharp.Patterns.FactoryMethod
{
    public abstract class AbstractCreator
    {
        public AbstractProduct Product { get; private set; }

        public abstract AbstractProduct FactoryMethod();

        public void Operation()
        {
            Product = FactoryMethod();
        }
    }
}