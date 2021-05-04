namespace Patterns.CSharp.Patterns.Builder
{
    public class UseCase : PatternUseCase
    {
        public UseCase()
        {
            AbstractBuilder builder;
            Director director;
            Product product;

            builder = new ConcreteBuilderOne();
            director = new Director(builder);
            director.Construct();
            product = builder.GetResult();
            product.Show();

            builder = new ConcreteBuilderTwo();
            director = new Director(builder);
            director.Construct();
            product = builder.GetResult();
            product.Show();
        }
    }
}