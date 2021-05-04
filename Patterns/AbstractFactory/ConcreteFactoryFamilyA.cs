namespace Patterns.CSharp.Patterns.AbstractFactory
{
    public class ConcreteFactoryFamilyA : AbstractFactory
    {
        public override AbstractProductOne CreateProductOne()
        {
            return new ConcreteProductOneFamilyA();
        }

        public override AbstractProductTwo CreateProductTwo()
        {
            return new ConcreteProductTwoFamilyA();
        }
    }
}