namespace Patterns.CSharp.Patterns.AbstractFactory
{
    public class ConcreteFactoryFamilyB : AbstractFactory
    {
        public override AbstractProductOne CreateProductOne()
        {
            return new ConcreteProductOneFamilyB();
        }

        public override AbstractProductTwo CreateProductTwo()
        {
            return new ConcreteProductTwoFamilyB();
        }
    }
}