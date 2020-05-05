namespace Patterns.CSharp.Patterns.FactoryMethod
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractCreator creator = new ConcreteCreatorOne();
            AbstractProduct product = creator.FactoryMethod();

            PatternUseCase.Output += creator.GetType().Name + " => " + product.GetType().Name + " \r\n\r\n";

            // Or
            creator = new ConcreteCreatorTwo();
            creator.Operation();
            product = creator.Product;

            PatternUseCase.Output += creator.GetType().Name + " => " + product.GetType().Name + " \r\n\r\n";
        }
    }
}