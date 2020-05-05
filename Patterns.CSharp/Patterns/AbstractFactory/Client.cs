namespace Patterns.CSharp.Patterns.AbstractFactory
{
    public class Client
    {
        private AbstractProductOne productOne;
        private AbstractProductTwo productTwo;

        public Client(AbstractFactory factory)
        {
            productOne = factory.CreateProductOne();
            productTwo = factory.CreateProductTwo();
        }

        public void Run()
        {
            productTwo.Interact(productOne);
        }
    }
}