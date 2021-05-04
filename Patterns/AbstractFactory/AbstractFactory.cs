namespace Patterns.CSharp.Patterns.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductOne CreateProductOne();
        public abstract AbstractProductTwo CreateProductTwo();
    }
}