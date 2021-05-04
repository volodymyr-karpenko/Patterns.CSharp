namespace Patterns.CSharp.Patterns.TemplateMethod
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractProduct product;

            product = new ConcreteProductOne();
            product.TemplateMethod();

            product = new ConcreteProductTwo();
            product.TemplateMethod();
        }
    }
}