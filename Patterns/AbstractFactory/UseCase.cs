namespace Patterns.CSharp.Patterns.AbstractFactory
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            Client client;

            client = new Client(new ConcreteFactoryFamilyA());
            client.Run();

            client = new Client(new ConcreteFactoryFamilyB());
            client.Run();
        }
    }
}